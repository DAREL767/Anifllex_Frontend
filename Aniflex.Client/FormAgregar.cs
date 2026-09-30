using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Aniflex.Client
{
    public partial class FormAgregar : Form
    {
        private readonly GraphQLService _service;

        public FormAgregar()
        {
            InitializeComponent();
            _service = new GraphQLService(); // <-- Inicializar el servicio
        }

        private void LimpiarCampos()
        {
            txtTitulo.Clear();
            txtDuracion.Clear();
            txtRecaudacion.Clear();
            chkEsSaga.Checked = false;
        }

        private async void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                string id = txtId.Text.Trim();
                if (string.IsNullOrEmpty(id))
                {
                    MessageBox.Show("Debes ingresar un ID.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                // 1. Lectura y casteo de datos desde los controles de la UI
                string titulo = txtTitulo.Text.Trim();

                if (string.IsNullOrEmpty(titulo))
                {
                    MessageBox.Show("El título es obligatorio.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Casteo/Parseo de cadenas a tipos numéricos
                if (!int.TryParse(txtDuracion.Text, out int duracion))
                {
                    MessageBox.Show("La duración debe ser un número entero válido (minutos).", "Error de entrada", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (!double.TryParse(txtRecaudacion.Text, out double recaudacion))
                {
                    MessageBox.Show("La recaudación debe ser un valor numérico válido.", "Error de entrada", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                bool esSaga = chkEsSaga.Checked;

                // 2. Creación del objeto Pelicula
                Pelicula nuevaPelicula = new Pelicula
                {
                    Id = id,
                    Titulo = titulo,
                    Duracion = duracion,
                    Recaudacion = recaudacion,
                    EsSaga = esSaga
                };

                // 3. Envío al backend
                Pelicula resultado = await _service.CrearPeliculaAsync(nuevaPelicula);

                if (resultado != null)
                {
                    MessageBox.Show($"Película '{resultado.Titulo}' creada con éxito (ID: {resultado.Id}).", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    PeliculaObserver.NotificarCambio();
                    LimpiarCampos();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al guardar: {ex.Message}", "Error de Servidor", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
