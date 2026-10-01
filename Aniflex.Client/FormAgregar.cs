using System;
using System.Windows.Forms;

namespace Aniflex.Client
{
    public partial class FormAgregar : Form
    {
        private readonly GraphQLService _service;

        public FormAgregar()
        {
            InitializeComponent();
            _service = new GraphQLService();

            btnGuardar.Click += btnGuardar_Click;
        }

        private async void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txtId.Text) || string.IsNullOrWhiteSpace(txtTitulo.Text))
                {
                    MessageBox.Show("El ID y el Título son obligatorios.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                Pelicula nueva = new Pelicula
                {
                    Id = txtId.Text.Trim(),
                    Titulo = txtTitulo.Text.Trim(),
                    Duracion = int.TryParse(txtDuracion.Text, out int dur) ? dur : 0,
                    Recaudacion = double.TryParse(txtRecaudacion.Text, out double rec) ? rec : 0,
                    EsSaga = chkEsSaga.Checked,
                    FechaEstreno = dtpFechaEstreno.Value.ToString("yyyy-MM-dd") // Lee la fecha del calendario
                };

                Pelicula creada = await _service.CrearPeliculaAsync(nueva);

                if (creada != null)
                {
                    MessageBox.Show("¡Película agregada con éxito!", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // Notificamos al Observer para refrescar la lista en vivo
                    PeliculaObserver.NotificarCambio();

                    LimpiarCampos();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al guardar: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LimpiarCampos()
        {
            txtId.Clear();
            txtTitulo.Clear();
            txtDuracion.Clear();
            txtRecaudacion.Clear();
            chkEsSaga.Checked = false;
            dtpFechaEstreno.Value = DateTime.Now;
        }
    }
}