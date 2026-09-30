namespace Aniflex.Client
{
    public partial class FormMenu : Form
    {
        public FormMenu()
        {
            InitializeComponent();
        }

        private void listarTodoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormListar formListar = new FormListar();
            formListar.Show();
        }

        private void agregarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormAgregar formAgregar = new FormAgregar();
            formAgregar.Show();
        }

        private void buscarConsultarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormBuscar formBuscar = new FormBuscar();
            formBuscar.Show();
        }

        private void actualizarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormActualizar formActualizar = new FormActualizar();
            formActualizar.Show();
        }

        private void eliminarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormEliminar formEliminar = new FormEliminar();
            formEliminar.Show();
        }
    }
}
