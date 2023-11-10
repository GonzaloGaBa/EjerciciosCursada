using System.Text;

namespace ClasesNegocios
{
    public class Celular
    {
        #region Atributos

        private EMarcas marca;
        private string modelo;
        private int ram;
        private double almacenamiento;
        private double almacenamientoActual;
        private bool encendido;
        private List<string> agenda; 
        private List<string> apps;
        #endregion

        #region Constructores
        public Celular()
        {
            this.Agenda = new List<string>();
            this.Apps = new List<string>();
        }
       

        public Celular(EMarcas marca, string modelo, int ram, double almacenamiento):this()
        {
            this.Marca = marca;
            this.Modelo = modelo;
            this.Ram = ram;
            this.almacenamiento = almacenamiento;
            this.Encendido = false;          
            this.AlmacenamientoActual = 0;
        }
        public Celular(EMarcas marca, string modelo, int ram, double almacenamiento, List<string> agenda):this(marca,modelo,ram,almacenamiento)  
        {
            this.Agenda = agenda;
        }
        
        #endregion

        #region Propiedades
        //////Sintaxsis de Metodo.
        //public string GetModelo()
        //{
        //    return this.modelo;
        //}

        //public void SetModelo(string value)
        //{
        //    this.modelo = Value;
        //}


        ////Sintaxsis de Propiedad.
        public string Modelo  
        {
            get
            {
                return this.modelo;
            }
            set
            {
                this.modelo = value;
            }
        }

        public EMarcas Marca { get => marca; set => marca = value; }
        public int Ram { get => ram; set => ram = value; }
        public double Almacenamiento { get => almacenamiento; set => almacenamiento = value; }
        public double AlmacenamientoActual { get => almacenamientoActual; set => almacenamientoActual = value; }
        public bool Encendido { get => encendido; set => encendido = value; }
        public List<string> Agenda { get => agenda; set => agenda = value; }
        public List<string> Apps { get => apps; set => apps = value; }

        #endregion

        #region Metodos de instancia
        public string AlternarEncendido()
        {
            this.Encendido = !this.Encendido;

            return this.Encendido ? "Encendido..." : "Apagado...";


            //string mensaje;
            //if (this.encendido == true)
            //{
            //    this.encendido = false;
            //    mensaje = "Apagado...";
            //}
            //else
            //{
            //    this.encendido = true;
            //    mensaje = "Encendido...";
            //}

            //return mensaje;
        }
        public void Llamar(string numero)
        {
            //Encendido
            if(this.encendido)
            {
                if (BuscarEnAgenda(numero))
                {
                    Console.WriteLine($"Llamando al numero: {numero}");
                }
                else
                {
                    Console.WriteLine("Numero no encontrado...");
                }
                
            }
            else
            {
                Console.WriteLine("El celular esta apago...");
            }
            //El numero tiene que estar agendado
        }

        public void Llamar(Contacto unContacto)
        {
            //Encendido
            if (this.encendido)
            {
                if (BuscarEnAgenda(unContacto.numero))
                {
                    Console.WriteLine($"Llamando al numero: {unContacto.nombre}");
                }
                else
                {
                    Console.WriteLine("Contacto no encontrado...");
                }

            }
            else
            {
                Console.WriteLine("El celular esta apago...");
            }
            //El numero tiene que estar agendado
        }
        #endregion

        #region Sobrecarga de Operadores
        private bool BuscarEnAgenda(string numeroIngresado)
        {
            bool estaEnAgenda;
            estaEnAgenda = false;
            foreach(string numero in this.agenda)
            {
                 if(numero == numeroIngresado)
                {
                    estaEnAgenda = true;
                    break;
                }
            }

            return estaEnAgenda;
        }

        private bool InstalarApp(App aplicacion) 
        {
            bool exito;
            exito = false;

            if(this.encendido && this != aplicacion && VerificarEspacio(aplicacion.size))
            {
                exito = true;
                this.apps.Add(aplicacion.nombre);
                this.almacenamientoActual += aplicacion.size; 
            }
            //Encendido
            //App no instalada
            //Tener espacio

            return exito;

        }

        private bool VerificarEspacio(double nuevoSize)
        {
            return (this.almacenamientoActual + nuevoSize) < this.almacenamiento;
        }

        public static bool operator == (Celular miCelu, App miApp)
        {
            bool exito;
            exito = false;

            foreach(string aplicacion in miCelu.apps) 
            {

                if(aplicacion == miApp.nombre)     
                {
                    exito = true;
                    break;
                }
            }

            return exito;
        }
        public static bool operator !=(Celular miCelu, App miApp)
        {
          
            return !(miCelu == miApp);
        }

        public static bool operator  + (Celular miCelu, App miApp)
        {

            return miCelu.InstalarApp(miApp);
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Marca: {this.marca}");
            sb.AppendLine($"Modelo: {this.modelo}");
            sb.AppendLine($"Ram: {this.ram}");
            sb.AppendLine($"Almacenamiento: {this.almacenamiento}");
            sb.AppendLine("Aplicaciones Instaladas");
            if (this.apps.Count > 0)
            {
                foreach(string aplicacion in apps)
                {
                    sb.AppendLine($"\t{aplicacion}");
                }
            }
            else
            {
                sb.AppendLine("No hay apps instaladas");
            }
            sb.AppendLine("*******************");
            return sb.ToString(); 
        }
        #endregion

        public static int ContarEnLista(List<Celular> lc, EMarcas m)
        {
            int contador = 0;

            if (lc == null)
            {
                return -1;
            }
                

            foreach (var item in lc)
            {
                if (item.Marca == m)
                {
                    contador++;
                }
            }
            return contador;
        }

    }
}