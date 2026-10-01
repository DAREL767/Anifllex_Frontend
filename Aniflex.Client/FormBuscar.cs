using System;
using System.Windows.Forms;

namespace Aniflex.Client
{
    public partial class FormBuscar : Form
    {
        private readonly GraphQLService _service;

        public FormBuscar()
        {
            InitializeComponent();
            _service = new GraphQLService();

        }

        private async void btnBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                string id = txtId.Text.Trim();

                if (string.IsNullOrEmpty(id))
                {
                    MessageBox.Show("Ingresa un ID para buscar.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                Pelicula p = await _service.ObtenerPeliculaPorIdAsync(id);

                if (p != null)
                {
                    txtTitulo.Text = p.Titulo;
                    txtDuracion.Text = p.Duracion.ToString();
                    txtRecaudacion.Text = p.Recaudacion.ToString();
                    chkEsSaga.Checked = p.EsSaga;

                    // Asignamos la fecha recibida al DateTimePicker
                    if (DateTime.TryParse(p.FechaEstreno, out DateTime fecha))
                    {
                        dtpFechaEstreno.Value = fecha;
                    }
                }
                else
                {
                    MessageBox.Show("No se encontró ninguna película con ese ID.", "Sin resultados", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LimpiarCampos();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al buscar: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LimpiarCampos()
        {
            txtTitulo.Clear();
            txtDuracion.Clear();
            txtRecaudacion.Clear();
            chkEsSaga.Checked = false;
            dtpFechaEstreno.Value = DateTime.Now;
        }
    }
}