namespace Clase_6
{
    public partial class FormularioInicial : Form
    {
        List<Empleado> listaEmpleados;
        List<string> listaTareas;
        public FormularioInicial()
        {
            InitializeComponent();
            listaEmpleados = new List<Empleado>();
            listaTareas = new List<string>();
        }

        private void FormularioInicial_Load(object sender, EventArgs e)
        {

        }

        private void FormularioInicial_Load_1(object sender, EventArgs e)
        {

        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            string nombre;
            float salario;
            string genero;

            nombre = txtNombre.Text;
            salario = float.Parse(txtSalario.Text);

            genero = rdoMasculino.Text;

            if (rdoFemenino.Checked)
            {
                genero = rdoFemenino.Text;
            }

            Empleado unEmpleado = new Empleado(nombre, salario, genero, listaTareas);

            MessageBox.Show(unEmpleado.ToString());


            listaEmpleados.Add(unEmpleado);

            MostrarLista(listaEmpleados);

            listaTareas.Clear();

        }

        private void MostrarLista(List<Empleado> lista)
        {
            lstEmpleados.Items.Clear();
            foreach (Empleado empleado in lista)
            {
                lstEmpleados.Items.Add(empleado.ToString());
            }
        }

        private void btnAgregarTareas_Click(object sender, EventArgs e)
        {
            listaTareas.Add(cmbTareas.Text);
        }

        private void lstEmpleados_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index;
            index = lstEmpleados.SelectedIndex;
            Empleado empleadoLista = listaEmpleados[index];
            ///MessageBox.Show(empleadoLista.ToString());

            dataGridView1.Rows.Clear();

            foreach(string tarea in empleadoLista.ListaTareas)
            {
                DataGridViewRow row = new DataGridViewRow();
                DataGridViewTextBoxCell cell = new DataGridViewTextBoxCell();
                cell.Value = tarea;
                row.Cells.Add(cell);
                dataGridView1.Rows.Add(row);
            }
     
        }
    }
}