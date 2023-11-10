using ClasesNegocios;

namespace Clase_4__Sobrecargas_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> agenda = new List<string>();
            agenda.Add("1111");
            agenda.Add("2222");
            agenda.Add("3333");

            Celular celular1 = new Celular(EMarcas.Samsung, "J7", 4, 64f, agenda);

            Console.WriteLine(celular1.AlternarEncendido());
            //Console.WriteLine(celular1.AlternarEncendido());
            //celular1.Llamar("555");

            //celular1.Llamar("1111");

            ///celular1.Modelo = "S20";//Sintaxsis de Propiedad.
            ///celular1.SetModelo("S20");//Sintaxsis de Metodo.

            ///Console.WriteLine(celular1.Modelo);//Sintaxsis de Propiedad.
            ///Console.WriteLine(celular1.GetModelo());//Sintaxsis de Metodo.

            Contacto miContacto = new Contacto("Gonzalo","5555");

            celular1.Llamar(miContacto);


            Console.WriteLine("********************************");

            App app1 = new App("Tinder", 40f);
            App app2 = new App("Wasapht", 20f);
            App app3 = new App("Instagram", 15f);

            List<App> listaApps = new List<App>();
            listaApps.Add(app1);
            listaApps.Add(app2);
            listaApps.Add(app3);
            bool exito;
            foreach(App aplicacion in listaApps)
            {
                exito = celular1 + aplicacion;
                if(exito)
                {
                    Console.WriteLine($"Existos al instalar {aplicacion.nombre}");
                }
                else
                {
                    Console.WriteLine($"Nose pudo instalar {aplicacion.nombre} por falta de memoria");
                }


            }


            Console.WriteLine(celular1.ToString());u

        }
    }
}