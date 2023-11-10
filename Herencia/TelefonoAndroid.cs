using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herencia
{
    public class TelefonoAndroid : TelefonoInteligente
    {
        private bool modoDesarrolloHabilitado;
        private bool versionesDePlayPotect;
        private float vesionAsistenteDeVoz;

        public TelefonoAndroid(string marca, string modelo, string color, float precio, string sistemaOperativo,
            bool poseeNfc, bool gpsActivado, string redesMoviles, float cantidadAlmacenamiento, bool modoDesarrolloHabilitado,
            bool versionesDePlayPotect, float vesionAsistenteDeVoz) : base(marca, modelo, color, precio, sistemaOperativo, poseeNfc, gpsActivado, redesMoviles, cantidadAlmacenamiento)
        {
            this.modoDesarrolloHabilitado = modoDesarrolloHabilitado;
            this.versionesDePlayPotect = versionesDePlayPotect;
            this.vesionAsistenteDeVoz = vesionAsistenteDeVoz;
        }

        public bool ModoDesarrolloHabilitado { get => modoDesarrolloHabilitado; set => modoDesarrolloHabilitado = value; }
        public bool VersionesDePlayPotect { get => versionesDePlayPotect; set => versionesDePlayPotect = value; }
        public float VesionAsistenteDeVoz { get => vesionAsistenteDeVoz; set => vesionAsistenteDeVoz = value; }

        

        public void RealizarVideollamada(String contacto)
        {
            Console.WriteLine("Realizando una videollamada a " + contacto + " utilizando Whatsapp.");
        }

        public void ActualizandoAndroid()
        {
            Console.WriteLine("Buscando actualizaciones de Android para este telefono " + Modelo + ".");
        }

        public void AlternarModoDesarrollo()
        {
            modoDesarrolloHabilitado = !modoDesarrolloHabilitado;
            if (modoDesarrolloHabilitado)
            {
                Console.WriteLine("Modo de desarrollo habilitado.");
            }
            else
            {
                Console.WriteLine("Modo de desarrollo desactivado.");
            }
        }

        public String MostrarAndroid()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine(Color);
            sb.AppendLine(Marca);
            sb.AppendLine(Modelo);
            sb.AppendLine(Precio.ToString());
            sb.AppendLine(modoDesarrolloHabilitado.ToString());
            sb.AppendLine(versionesDePlayPotect.ToString());
            sb.AppendLine(vesionAsistenteDeVoz.ToString());


            return sb.ToString();
        }
    }
}
