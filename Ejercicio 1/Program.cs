using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Cuántos billetes de 50, 10, 20 y 100 soles y monedas de 0.1, 0.2, 0.5, 1, 2 y 5 soles
            //recibirán un empleado como pago por su trabajo? Suponga que se le debe entregar la
            //máxima cantidad posible de billetes y monedas de cada denominación(5 puntos).

            decimal totalPago;
            Console.WriteLine("Ingrese el monto total que se le debe pagar al empleado: ");
            totalPago = decimal.Parse(Console.ReadLine());

            int billetes100 = 0, billetes50 = 0, billetes20 = 0, billetes10 = 0;
            int monedas5 = 0, monedas2 = 0, monedas1 = 0, monedas05 = 0, monedas02 = 0, monedas01 = 0;

            //La división de totalPago por por el valor de la moneda nos da cuántas monedas de cada valor podemos entregar.
            //Este proceso se repite para todas las denominaciones de monedas y billetes de acuerdo con su valor.
            billetes100 = (int)(totalPago / 100);
            totalPago -= billetes100 * 100;

            billetes50 = (int)(totalPago / 50);
            totalPago -= billetes50 * 50;

            billetes20 = (int)(totalPago / 20);
            totalPago -= billetes20 * 20;

            billetes10 = (int)(totalPago / 10);
            totalPago -= billetes10 * 10;

            monedas5 = (int)(totalPago / 5);
            totalPago -= monedas5 * 5;

            monedas2 = (int)(totalPago / 2);
            totalPago -= monedas2 * 2;

            monedas1 = (int)(totalPago / 1);
            totalPago -= monedas1 * 1;

            monedas05 = (int)(totalPago / 0.5m);
            totalPago -= monedas05 * 0.5m;

            monedas02 = (int)(totalPago / 0.2m);
            totalPago -= monedas02 * 0.2m;

            monedas01 = (int)(totalPago / 0.1m);
            totalPago -= monedas01 * 0.1m;

            Console.WriteLine("\nBilletes de 100 soles: " + billetes100);
            Console.WriteLine("Billetes de 50 soles: " + billetes50);
            Console.WriteLine("Billetes de 20 soles: " + billetes20);
            Console.WriteLine("Billetes de 10 soles: " + billetes10);
            Console.WriteLine("Monedas de 5 soles: " + monedas5);
            Console.WriteLine("Monedas de 2 soles: " + monedas2);
            Console.WriteLine("Monedas de 1 sol: " + monedas1);
            Console.WriteLine("Monedas de 0.5 soles: " + monedas05);
            Console.WriteLine("Monedas de 0.2 soles: " + monedas02);
            Console.WriteLine("Monedas de 0.1 soles: " + monedas01);
        }
    }
}
