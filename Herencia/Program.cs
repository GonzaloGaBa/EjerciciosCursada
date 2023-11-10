namespace Herencia
{
    internal class Program
    {
        static void Main(string[] args)
        {
            TelefonoAndroid primerTelefono = new TelefonoAndroid("Samsung", "A24", "Negro", 150.000f, "Android 20", false, 
                true, "4g", 84f, false, true, 52f);

            Console.WriteLine(primerTelefono.MostrarAndroid());


            TelefonoDeJuguete telefonoRosa = new TelefonoDeJuguete("De toys", "2", "Rosa", 5000f, "Plastico", "No tiene", true);
            telefonoRosa.AcitvarLuces();
            telefonoRosa.ReproducirCancionBarbieGirl();


        }
    }
}