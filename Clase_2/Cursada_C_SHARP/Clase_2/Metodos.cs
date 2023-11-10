using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OtroNameSpace
{
    internal class Metodos
    {
        /// <summary>
        /// Determina si un numero es par o impar.
        /// </summary>
        /// <param name="num"></param>
        /// <returns>True: Si es par - False: Si es impar.</returns>
        /// <exception cref="IOException"></exception>
        public static bool DeterminarParidad(ref int num)
        {
            num = 555;
            return (num % 2 == 0);
          
        }
        public static void HacerAlgo(string nombre)
        {
            nombre = "Gabriel";
        }

        public static void ModificarVector(int[] vector)
        {
            vector[2] = 4444;  
        }
    }
}
