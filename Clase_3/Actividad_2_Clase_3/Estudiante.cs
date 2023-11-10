using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Actividad_2_Clase_3
{
    public class Estudiante
    {
        private static Random random = new Random();

        private string Nombre;
        private string Apellido;
        private int Legajo;
        private int NotaPrimerParcial;
        private int NotaSegundoParcial;

        public Estudiante(string Nombre,string Apellido,int Legajo)
        {
            this.Nombre = Nombre;
            this.Apellido = Apellido;
            this.Legajo = Legajo;

        }
        public void SetNotaPrimerParcial(int nota)
        {
            NotaPrimerParcial = nota;
        }

        public void SetNotaSegundoParcial(int nota)
        {
            NotaSegundoParcial = nota;
        }

        private double CalcularPromedio()
        { 
            return (NotaPrimerParcial+NotaSegundoParcial) / 2.0;
        }

        public int CalcularNotaFinal()
        {
            if (NotaPrimerParcial >= 4 && NotaSegundoParcial >= 4)
            {
                 return random.Next(6, 11);
            }
            else
            {
                return -1;
            }
        }


        public void Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Nombre: {Nombre}");
            sb.AppendLine($"Apellido: {Apellido}");
            sb.AppendLine($"Legajo: {Legajo}");
            sb.AppendLine($"Nota del primer Parcial: {NotaPrimerParcial}");
            sb.AppendLine($"Nota del segundo Parcial: {NotaSegundoParcial}");
            sb.AppendLine($"PROMEDIO: {CalcularPromedio():F2}");

            int notaFinal = CalcularNotaFinal();
            if (notaFinal != -1)
            {
                sb.AppendLine($"Nota Final: {notaFinal}");
            }
            else 
            {
                sb.AppendLine("Alumno desaprobado");
            }
            
            Console.WriteLine(sb.ToString());
        }
    }
}
