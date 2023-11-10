using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace SerealiazacionHerencias
{
    [Serializable]
    [XmlInclude(typeof(Cadete))]
    [XmlInclude(typeof(Administrativo))]

    public abstract class Empleado
    {
        protected string nombre;
        protected float salario;

        public Empleado()
        {
            
        }

        public Empleado(string nombre, float salario)
        {
            this.nombre = nombre;
            this.salario = salario;
        }

        public string Nombre { get => nombre; set => nombre = value; }
        public float Salario { get => salario; set => salario = value; }


        public override string ToString()
        {
            return $"{nombre} -- {salario}";
        }
    }
}
