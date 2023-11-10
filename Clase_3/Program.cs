namespace Clase_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine($"Todos los celulares perteneces al Sistema Operativo: {Celular._sistemaOperativo}");


            Celular miCelular;
            miCelular = new Celular(false, "j7");
            miCelular.Llamar("4444");
            
            /*
            miCelular.setEstaEncendido(true);
            Console.WriteLine($"Modelo: {miCelular.getModelo} - Estado: {miCelular.getEstaEncendido} ");
            miCelular.setEstaEncendido(false);
            */
            /*
            Celular otroCelular = new Celular(false, "ipone 14");

            Console.WriteLine($"Modelo: {otroCelular.getModelo} - Estado: {otroCelular.getEstaEncendido} ");
            */
        }
    }
}