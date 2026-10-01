using System;
using System.Windows.Forms;

namespace Aniflex.Client
{
    public partial class FormActualizar : Form
    {
        private readonly GraphQLService _service;

        public FormActualizar()
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

                    if (DateTime.TryParse(p.FechaEstreno, out DateTime fecha))
                    {
                        dtpFechaEstreno.Value = fecha;
                    }
                }
                else
                {
                    MessageBox.Show("No se encontró ninguna película con ese ID.", "Sin resultados", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al buscar: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void btnActualizar_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txtId.Text) || string.IsNullOrWhiteSpace(txtTitulo.Text))
                {
                    MessageBox.Show("Busca o ingresa un ID y Título válidos.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                Pelicula editada = new Pelicula
                {
                    Id = txtId.Text.Trim(),
                    Titulo = txtTitulo.Text.Trim(),
                    Duracion = int.TryParse(txtDuracion.Text, out int dur) ? dur : 0,
                    Recaudacion = double.TryParse(txtRecaudacion.Text, out double rec) ? rec : 0,
                    EsSaga = chkEsSaga.Checked,
                    FechaEstreno = dtpFechaEstreno.Value.ToString("yyyy-MM-dd")
                };

                Pelicula resultado = await _service.ActualizarPeliculaAsync(editada);

                if (resultado != null)
                {
                    MessageBox.Show("¡Película actualizada con éxito!", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // Notificamos al Observer para refrescar la lista automáticamente
                    PeliculaObserver.NotificarCambio();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al actualizar: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}