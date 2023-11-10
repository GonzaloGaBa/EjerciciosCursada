using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase_6
{
    public class Empleado
    {
        string nombre;
        float salario;
        string genero;
        List<String>  listaTareas;

        public Empleado(string nombre, float salario, string genero, List<string> listaTareas)
        {
            this.Nombre = nombre;
            this.Salario = salario;
            this.Genero = genero;
            this.ListaTareas = new List<string>(listaTareas);
        }

        public string Nombre { get => nombre; set => nombre = value; }
        public float Salario { get => salario; set => salario = value; }
        public string Genero { get => genero; set => genero = value; }
        public List<string> ListaTareas { get => listaTareas; set => listaTareas = value; }


        public override string ToString()
        {
            return Nombre + "-" + Salario + "-" + Genero;
        }

    }
}
