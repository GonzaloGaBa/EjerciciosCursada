using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Actividad_1_clase_3
{
    public class Cuenta
    {
        //Atributos
        private string titular;
        private decimal cantidad;

        public Cuenta(string titular, decimal cantidad)
        {
            this.titular = titular;
            this.cantidad = cantidad;
        }

        //Metodos Getter
        public string GetTitular()
        {
            return titular;
        }

        public decimal GetCantidad()
        {
            return cantidad;
        }

        public string CuentaToString()
        {
            return $"Razon social del titular: {titular} \n Cantidad de dinero: {cantidad}";
        }

        public void IngresarDinero(decimal monto)
        {
            if (monto > 0)
            {
                cantidad += monto;
                Console.WriteLine($"Se ha depositado {monto} en su cuenta. \nSaldo Actual: {cantidad}");
            }
            else
            {
                Console.WriteLine("Saldo Insuficiente");
            }
        }

        public void RetirarDinero(decimal monto)
        {
            cantidad -= monto;
            Console.WriteLine($"Se ha Retirado {monto} de su cuenta. \nSaldo Acutal: {cantidad}");

        }
    }
}
