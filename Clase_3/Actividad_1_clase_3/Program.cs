namespace Actividad_1_clase_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Crear una cuenta con un saldo Inicial
            Cuenta cuenta = new Cuenta("Estudiante", 200000);

            Console.WriteLine("INFORMACION DE LA CUENTA INICIAL: \n");
            Console.WriteLine(cuenta.CuentaToString());

            //Simular entrada y salida de dinero
            cuenta.IngresarDinero(55000);
            cuenta.RetirarDinero(122000);
            cuenta.IngresarDinero(1200);
            cuenta.RetirarDinero(900000);

            Console.WriteLine("\nINFORMACION DE LA CUENTA FINAL: ");
            Console.WriteLine(cuenta.CuentaToString());

            
        }
    }
}