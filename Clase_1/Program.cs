namespace Clase_1
{
    internal class Program
    {
        static void Main()//Entry point
        {
            string nombre;
            int edad;
            try
            {
                 Console.BackgroundColor = ConsoleColor.Green;
                 Console.WriteLine("Ingrese su nombre: ");
                 nombre = Console.ReadLine();
                 Console.WriteLine("Ingrese su edad: ");
                 edad = int.Parse(Console.ReadLine());

                 Console.WriteLine($"Tu nombre es: {nombre} y tenes {edad} años.");
            }
            catch(Exception ex) 
            {
                Console.WriteLine("Error...");
            }
            finally
            {
                Console.WriteLine("Fin del programa.");
            }
        }   
        

    }
}