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
    public partial class ListadoCelulares : Form
    {
        List<Celular> listaCelulares;
        public ListadoCelulares()
        {
            InitializeComponent();
            this.listaCelulares = new List<Celular>();
        }

        private void ListadoCelulares_Load(object sender, EventArgs e)
        {
            //EMarcas marca, string modelo, int ram, double almacenamiento
            this.listaCelulares.Add(new Celular(EMarcas.Apple, "14", 16, 128));
            this.listaCelulares.Add(new Celular(EMarcas.Samsung, "22", 16, 128));
            this.listaCelulares.Add(new Celular(EMarcas.Xiaomi, "M9", 16, 64));
            this.listaCelulares.Add(new Celular(EMarcas.Huawei, "HOLA", 4, 16));
            this.listaCelulares.Add(new Celular(EMarcas.Motorola, "CHAU", 8, 32));
            this.listaCelulares.Add(new Celular(EMarcas.Apple, "IPOD", 32, 128));
            this.listaCelulares.Add(new Celular(EMarcas.Samsung, "J7 PRIME", 1, 12));

            this.dtgCelulares.DataSource = this.listaCelulares;
            this.dtgCelulares.Columns["Encendido"].Visible = false;

            //object c = this.dtgCelulares.Rows[0].Cells[0].Value;
            //MessageBox.Show(c.ToString());
           }
    }
}
