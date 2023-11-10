using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase_3
{
    internal class Celular
    {
        private bool _estaEncendido;
        private string _modelo;
        public static string _sistemaOperativo;

        //Por defecto: ref(objeto - string: Se inicializan con NULL)
        //int: 0
        //float: 0.0
        //bool: false


        static Celular()
        {
            _sistemaOperativo = "Android 2.5";
        }


       
        public Celular(bool estaEncendido,string modelo)//Sobrecarga de un Constructor
        {
            this._estaEncendido = estaEncendido;
            this._modelo = modelo;
            
        }

        public bool getEstaEncendido()
        {
            return _estaEncendido;
        }

        public string getModelo()
        {
            return _modelo;
        }

        public void setEstaEncendido(bool value)
        {
            this._estaEncendido = value;
        }

        public void Llamar(string numero)
        {
            if(this._estaEncendido)
            {
                Console.WriteLine($"Estoy llamando al numero: {numero}");
            }
            else
            {
                Console.WriteLine("Deberia encender el celular");
            }
        }
    }
}
