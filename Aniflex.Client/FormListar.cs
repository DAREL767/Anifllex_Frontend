using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Aniflex.Client
{
    public partial class FormListar : Form
    {
        private readonly GraphQLService _service;

        public FormListar()
        {
            InitializeComponent();
            _service = new GraphQLService();

            // Suscripción al Observer
            PeliculaObserver.OnPeliculasCambiadas += RefrescarGrilla;
        }

        private async void FormListar_Load(object sender, EventArgs e)
        {
            await CargarPeliculas();
        }

        private async System.Threading.Tasks.Task CargarPeliculas()
        {
            try
            {
                List<Pelicula> peliculas = await _service.ObtenerPeliculasAsync();
                dgvPeliculas.DataSource = null;
                dgvPeliculas.DataSource = peliculas;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar películas: {ex.Message}");
            }
        }

        private async void RefrescarGrilla()
        {
            // Método que invoca el Observer cuando ocurre una modificación
            await CargarPeliculas();
        }

        private void FormListar_FormClosed(object sender, FormClosedEventArgs e)
        {
            // Desuscripción limpia del Observer
            PeliculaObserver.OnPeliculasCambiadas -= RefrescarGrilla;
        }
    }
}

