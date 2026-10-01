using System;
using System.Collections.Generic;
using System.Threading.Tasks;
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

            // Vinculación explícita de botones
            btnCargar.Click += async (s, e) => await CargarPeliculasConFiltro(null, null);
            btnFiltrarSaga.Click += async (s, e) => await CargarPeliculasConFiltro(true, null);
            btnFiltrarTitulo.Click += btnFiltrarTitulo_Click;

            // Suscripción al Observer
            PeliculaObserver.OnPeliculasCambiadas += RefrescarGrilla;
        }

        private async void FormListar_Load(object sender, EventArgs e)
        {
            await CargarPeliculasConFiltro(null, null);
        }

        private async void btnFiltrarTitulo_Click(object sender, EventArgs e)
        {
            // Pide el título a buscar mediante un prompt rápido
            string busqueda = Microsoft.VisualBasic.Interaction.InputBox("Ingresa el título a buscar:", "Filtrar por Título", "");
            if (!string.IsNullOrWhiteSpace(busqueda))
            {
                await CargarPeliculasConFiltro(null, busqueda);
            }
        }

        private async Task CargarPeliculasConFiltro(bool? esSaga, string titulo)
        {
            try
            {
                List<Pelicula> peliculas = await _service.ObtenerPeliculasAsync(esSaga, titulo);
                dgvPeliculas.DataSource = null;
                dgvPeliculas.DataSource = peliculas;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al listar: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void RefrescarGrilla()
        {
            await CargarPeliculasConFiltro(null, null);
        }

        private void FormListar_FormClosed(object sender, FormClosedEventArgs e)
        {
            PeliculaObserver.OnPeliculasCambiadas -= RefrescarGrilla;
        }
    }
}