using System;
using System.Windows.Forms;

namespace Aniflex.Client
{
    public partial class FormEliminar : Form
    {
        private readonly GraphQLService _service;

        public FormEliminar()
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
                    LimpiarCampos();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al buscar: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                string id = txtId.Text.Trim();

                if (string.IsNullOrEmpty(id))
                {
                    MessageBox.Show("Busca o ingresa un ID válido para eliminar.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                var confirmacion = MessageBox.Show($"¿Estás seguro de eliminar la película con ID '{id}'?", "Confirmar eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (confirmacion == DialogResult.Yes)
                {
                    bool eliminado = await _service.EliminarPeliculaAsync(id);

                    if (eliminado)
                    {
                        MessageBox.Show("¡Película eliminada correctamente!", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        // Notificamos al Observer para refrescar la lista
                        PeliculaObserver.NotificarCambio();

                        LimpiarCampos();
                        txtId.Clear();
                    }
                    else
                    {
                        MessageBox.Show("No se pudo eliminar la película.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al eliminar: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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