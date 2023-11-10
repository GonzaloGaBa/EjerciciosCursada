using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herencia
{
    internal class Telefono
    {
        private string marca;
        private string modelo;
        private string color;
        private float precio;
        private string sistemaOperativo;
        private bool poseeNfc;
        private string redesMoviles;
        private float cantidadAlmacenamiento;
        private bool gpsActivado;
        

        public Telefono(string marca, string modelo, string color, float precio, string sistemaOperativo, bool poseeNfc,
            string redesMoviles, float cantidadAlmacenamiento, bool gpsActivado)
        {
            this.marca = marca;
            this.modelo = modelo;
            this.color = color;
            this.precio = precio;
            this.sistemaOperativo = sistemaOperativo;
            this.poseeNfc = poseeNfc;
            this.redesMoviles = redesMoviles;
            this.cantidadAlmacenamiento = cantidadAlmacenamiento;
            this.gpsActivado = gpsActivado;
            
        }

        public string Marca { get => marca; set => marca = value; }
        public string Modelo { get => modelo; set => modelo = value; }
        public string Color { get => color; set => color = value; }
        public float Precio { get => precio; set => precio = value; }
        public string SistemaOperativo { get => sistemaOperativo; set => sistemaOperativo = value; }
        public bool PoseeNfc { get => poseeNfc; set => poseeNfc = value; }
        public string RedesMoviles { get => redesMoviles; set => redesMoviles = value; }
        public float CantidadAlmacenamiento { get => cantidadAlmacenamiento; set => cantidadAlmacenamiento = value; }
        public bool GpsActivado { get => gpsActivado; set => gpsActivado = value; }
       
    }
}
