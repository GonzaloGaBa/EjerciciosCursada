namespace SerealiazacionHerencias
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string ruta = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            string nombre = @"\MisEmpleados.xml";
            string path = ruta + nombre;



            Empleado admin1 = new Administrativo("Gonzalo", 300000, true, 14);
            Cadete cadete1 = new Cadete("Javier", 2000, false);
            Empleado admin2 = new Administrativo("Kate", 18000, true, 44);
            Cadete cadete2 = new Cadete("Claudia", 34000, true);

            List<Empleado> listaEmpleados = new List<Empleado>();
            listaEmpleados.Add(admin1);
            listaEmpleados.Add(cadete1);
            listaEmpleados.Add(admin2);
            listaEmpleados.Add(cadete2);

            List<Empleado> lista;

            try
            {
                //Serializadora.EscribirXML(path, listaEmpleados);

                //Serializadora.EscribirJson(path, listaEmpleados);


                list = Serializadora.LeerJson(path);

                foreach (Empleado emp in list)
                {
                    Console.WriteLine(emp.ToString());
                }

            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.ToString());
            }
        }
    }
}