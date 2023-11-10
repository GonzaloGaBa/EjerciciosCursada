namespace Clase_2
{
    using System.Text;
    using TT = OtroNameSpace.Metodos;
    internal class Program
    {
        static void Main(string[] args)
        {
            StringBuilder sb = new StringBuilder();
            string nombre = "Gonzalo Barrientos";
            char[] arrayNombre = nombre.ToCharArray();

            for (int i = 0; i < arrayNombre.Length; i++)
            {
                Console.WriteLine("\t****{0}", arrayNombre[i]);
            }


            /*String Nombre = "Gonzalo";
            String Apellio = "Barrientos";         
            int Edad = 27;
            sb.Append($"Su nombre es {Nombre}\n");
            sb.Append($"Su Apellido es {Apellio}\n");
            sb.Append($"y tiene {Edad} años.\n");

            Console.WriteLine(sb);*/

            int compara = String.Compare(nombre, "Gonzalo");
            Console.WriteLine(compara);

            bool contiene = nombre.Contains("Gonzalo");
            Console.WriteLine(contiene);

            int indice = nombre.IndexOf("n");
            Console.WriteLine(indice);

            string otroNombre = nombre.Trim();

            Console.WriteLine($"{otroNombre} Fin del nombre.");

        }



    }
}