using ClasesNegocios;
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
    public partial class FormStock : Form
    {
        List<Celular> listaCelulares;
        public FormStock()
        {
            InitializeComponent();
        }

        private void FormStock_Load(object sender, EventArgs e)
        {
            this.listaCelulares = new List<Celular>();
            //EMarcas marca, string modelo, int ram, double almacenamiento
            this.listaCelulares.Add(new Celular(EMarcas.Apple, "14", 16, 128));
            this.listaCelulares.Add(new Celular(EMarcas.Samsung, "22", 16, 128));
            this.listaCelulares.Add(new Celular(EMarcas.Xiaomi, "M9", 16, 64));
            this.listaCelulares.Add(new Celular(EMarcas.Huawei, "HOLA", 4, 16));
            this.listaCelulares.Add(new Celular(EMarcas.Motorola, "CHAU", 8, 32));
            this.listaCelulares.Add(new Celular(EMarcas.Apple, "IPOD", 32, 128));
            this.listaCelulares.Add(new Celular(EMarcas.Samsung, "J7 PRIME", 1, 12));

            Dictionary<EMarcas, int> stock = new Dictionary<EMarcas, int>();

            stock[EMarcas.Apple] = Celular.ContarEnLista(listaCelulares, EMarcas.Apple);
            stock[EMarcas.Samsung] = Celular.ContarEnLista(listaCelulares, EMarcas.Samsung);
            stock[EMarcas.Motorola] = Celular.ContarEnLista(listaCelulares, EMarcas.Motorola);
            stock[EMarcas.Xiaomi] = Celular.ContarEnLista(listaCelulares, EMarcas.Xiaomi);
            stock[EMarcas.Huawei] = Celular.ContarEnLista(listaCelulares, EMarcas.Huawei);

            BindingSource bs = new BindingSource();

            bs.DataSource = stock;

            this.dtgStock.DataSource = bs;

        }

        private void FormStock_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult dg =MessageBox.Show("Desea cerra la ventana?","Cerrado",MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning);

            if (dg == DialogResult.No) 
            {
                e.Cancel = true;
            }
        }
    }
}
