namespace Interfaz
{
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();  
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            string usuario = this.txtUsuario.Text;
            string clave = this.txtClave.Text;
            if (usuario == "Gonzalo" && clave == "1234")
            {
                //MessageBox.Show("Usuario logeado correctamente", "Login In",
                //    MessageBoxButtons.OK,MessageBoxIcon.Information);
                VentanaEmergente ver = new VentanaEmergente("Login In", "Usuario logeado correctamente");
                ver.ShowDialog();

                if (ver.DialogResult == DialogResult.OK)
                {
                    MenuPrincipal mp = new MenuPrincipal();
                    mp.Show();
                    this.Hide();

                }
            }
            else
            {
                MessageBox.Show("Usuario/Clave Incorrecta", "Login In",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}