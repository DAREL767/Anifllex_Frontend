using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
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
    }
}
