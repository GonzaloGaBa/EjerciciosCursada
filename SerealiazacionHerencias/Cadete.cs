    using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SerealiazacionHerencias
{
    [Serializable]
    public class Cadete : Empleado
    {
        bool tieneMoto;

        public Cadete()
        {
            
        }

        public Cadete(string nombre, float salario,bool tieneMoto) : base(nombre, salario)
        {
            this.tieneMoto = tieneMoto;
        }

        public bool TieneMoto { get => tieneMoto; set => tieneMoto = value; }

        public override string ToString()
        {
            return base.ToString() + $" ¿Tiene moto? {tieneMoto}" ;
        }
    }
}
