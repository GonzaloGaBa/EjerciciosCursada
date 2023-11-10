using System.Transactions;

namespace Herencia
{
    internal class Program
    {
        static void Main(string[] args)
        {
            TelefonoAndroid primerTelefono = new TelefonoAndroid("Samsung","A24","Negro",150.000f,"Android 20",false,"4g",500f,false,false,true,52f);

            Console.WriteLine(primerTelefono.MostrarAndroid());
        }
    }
}