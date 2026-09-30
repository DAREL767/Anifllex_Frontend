using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
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

        private async void btnActualizar_Click(object sender, EventArgs e)
        {
            try
            {
                string id = txtId.Text.Trim();

                if (string.IsNullOrEmpty(id) || !int.TryParse(txtDuracion.Text, out int duracion) || !double.TryParse(txtRecaudacion.Text, out double recaudacion))
                {
                    MessageBox.Show("Verifica que los campos contengan valores numéricos válidos.");
                    return;
                }

                Pelicula pEditada = new Pelicula
                {
                    Id = id,
                    Titulo = txtTitulo.Text.Trim(),
                    Duracion = duracion,
                    Recaudacion = recaudacion,
                    EsSaga = chkEsSaga.Checked
                };

                Pelicula resultado = await _service.ActualizarPeliculaAsync(pEditada);

                if (resultado != null)
                {
                    MessageBox.Show("Película actualizada exitosamente.");
                    PeliculaObserver.NotificarCambio();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al actualizar: {ex.Message}");
            }
        }
    }
}
