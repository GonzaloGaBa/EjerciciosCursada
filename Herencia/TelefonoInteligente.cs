﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herencia
{
    public class TelefonoInteligente : Telefono
    {
        private string sistemaOperativo;
        private bool poseeNfc;
        private bool gpsActivado;
        private string redesMoviles;
        private float cantidadAlmacenamiento;
        

        public TelefonoInteligente(string marca, string modelo, string color, float precio,string sistemaOperativo, bool poseeNfc, bool gpsActivado,
            string redesMoviles, float cantidadAlmacenamiento) : base(marca,modelo,color,precio)
        {
            this.sistemaOperativo = sistemaOperativo;
            this.poseeNfc = poseeNfc;
            this.gpsActivado = gpsActivado;
            this.redesMoviles = redesMoviles;
            this.cantidadAlmacenamiento = cantidadAlmacenamiento;
          
        }

        public string SistemaOperativo { get => sistemaOperativo; set => sistemaOperativo = value; }
        public bool PoseeNfc { get => poseeNfc; set => poseeNfc = value; }
        public bool GpsActivado { get => gpsActivado; set => gpsActivado = value; }
        public string RedesMoviles { get => redesMoviles; set => redesMoviles = value; }
        public float CantidadAlmacenamiento { get => cantidadAlmacenamiento; set => cantidadAlmacenamiento = value; }
        



        public void InstalarApp(String nombreApp)
        {
            Console.WriteLine("Instalando la aplicacion " + nombreApp + "desde la App Store.");

        }

        public void RealizarVideollamada(String contacto)
        {
            Console.WriteLine("Realizando una videollamada a " + contacto + " utilizando FaceTime.");
        }
    }
}
