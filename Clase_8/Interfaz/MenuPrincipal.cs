using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Interfaz
{
    public partial class MenuPrincipal : Form
    {
        Form formulario;
        public MenuPrincipal()
        {
            InitializeComponent();
        }

        private void cELULARESToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.formulario = new ListadoCelulares();

            this.formulario.MdiParent = this;
            this.pictureBox1.Visible = false;
            this.formulario.Show();
        }

        private void iNICIOToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.formulario.Close();
            this.pictureBox1.Visible = true;
        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            FormStock fs = new FormStock();
            fs.Show();
        }

        
    }
}
