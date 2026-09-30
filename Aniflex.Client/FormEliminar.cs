using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
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
                    MessageBox.Show("Por favor ingresa un ID.");
                    return;
                }

                Pelicula p = await _service.ObtenerPeliculaPorIdAsync(id);

                if (p != null)
                {
                    txtTitulo.Text = p.Titulo;
                    txtDuracion.Text = p.Duracion.ToString();
                    txtRecaudacion.Text = p.Recaudacion.ToString();
                    chkEsSaga.Checked = p.EsSaga;
                }
                else
                {
                    MessageBox.Show("No se encontró ninguna película con ese ID.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error en la búsqueda: {ex.Message}");
            }
        }

        private async void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                string id = txtId.Text.Trim();

                if (string.IsNullOrEmpty(id))
                {
                    MessageBox.Show("Ingresa el ID de la película a eliminar.");
                    return;
                }

                var confirmacion = MessageBox.Show("¿Estás seguro de que deseas eliminar esta película?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (confirmacion == DialogResult.Yes)
                {
                    bool eliminado = await _service.EliminarPeliculaAsync(id);

                    if (eliminado)
                    {
                        MessageBox.Show("Película eliminada correctamente.");
                        PeliculaObserver.NotificarCambio();
                        txtId.Clear();
                    }
                    else
                    {
                        MessageBox.Show("No se pudo eliminar o el ID no existe.");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al eliminar: {ex.Message}");
            }
        }
    }
}
