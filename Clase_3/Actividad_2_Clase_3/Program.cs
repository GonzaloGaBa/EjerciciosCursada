namespace Actividad_2_Clase_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Estudiante estudiante1 = new Estudiante("Ricardo","Fort",125542);
            Estudiante estudiante2 = new Estudiante("Oliver", "Atom", 145264);
            Estudiante estudiante3 = new Estudiante("Pocho", "LaPantera", 123472);

            //Notas de los parciales
            estudiante1.SetNotaPrimerParcial(7);
            estudiante1.SetNotaSegundoParcial(9);

            estudiante2.SetNotaPrimerParcial(5);
            estudiante2.SetNotaSegundoParcial(8);

            estudiante3.SetNotaPrimerParcial(2);
            estudiante3.SetNotaSegundoParcial(3);

            //Mostrar datos de todos los alumnos
            Console.WriteLine("DATOS DE LOS ESTUDIANTES:\n");
            Console.WriteLine("---------------------------\n");
            estudiante1.Mostrar();
            Console.WriteLine("---------------------------\n");
            estudiante2.Mostrar();
            Console.WriteLine("---------------------------\n");
            estudiante3.Mostrar();
            Console.WriteLine("-----------------------------");

            Console.ReadLine();

        }
    }
}