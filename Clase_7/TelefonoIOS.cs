using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Herencia
{
    internal class TelefonoIOS : Telefono
    {
        private bool tieneFaceID;
        private bool iCloudActivado;
        private float vesionDeSiri;

        public TelefonoIOS(string marca, string modelo, string color, float precio, string sistemaOperativo, bool poseeNfc, string redesMoviles,
            float cantidadAlmacenamiento, bool gpsActivado, bool tieneFaceID, bool iCloudActivado, float vesionDeSiri) : base
            (marca, modelo, color, precio, sistemaOperativo, poseeNfc, redesMoviles, cantidadAlmacenamiento, gpsActivado)
        {

            this.tieneFaceID = tieneFaceID;
            this.iCloudActivado = iCloudActivado;
            this.vesionDeSiri = vesionDeSiri;
        }

        public bool TieneFaceID { get => tieneFaceID; set => tieneFaceID = value; }
        public bool ICloudActivado { get => iCloudActivado; set => iCloudActivado = value; }
        public float VesionDeSiri { get => vesionDeSiri; set => vesionDeSiri = value; }
        public void InstalarApp(String nombreApp)
        {
            Console.WriteLine("Instalando la aplicacion " + nombreApp + "desde la App Store.");

        }

        public void RealizarVideollamada(String contacto)
        {
            Console.WriteLine("Realizando una videollamada a " + contacto + " utilizando Whatsapp.");
        }

        public void PersonalizarInterfaz()
        {
            Console.WriteLine("Personzalidando la interfaz de Ios");
        }

        
    }
}
