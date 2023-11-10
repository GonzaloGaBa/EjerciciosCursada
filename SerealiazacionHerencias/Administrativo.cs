using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SerealiazacionHerencias
{
    [Serializable]
    public class Administrativo:Empleado
    {
        bool haceHome;
        int diasDeVacaciones;

        public Administrativo()
        {
            
        }

        public Administrativo(string nombre,float salario,bool haceHome, int diasDeVacaciones) :
            base(nombre,salario)
        {
            this.haceHome = haceHome;
            this.diasDeVacaciones = diasDeVacaciones;
        }

        public bool HaceHome { get => haceHome; set => haceHome = value; }
        public int DiasDeVacaciones { get => diasDeVacaciones; set => diasDeVacaciones = value; }

        public override string ToString()
        {
            return base.ToString() + $"¿Hace Home? {haceHome} -- Dias de Vacaciones: {diasDeVacaciones}" ;
        }
    }
}
