using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese el sueldo del empleado:");
            double sueldo = double.Parse(Console.ReadLine());

            double impuesto = 0;
            double sueldoNeto = sueldo;

            if (sueldo <= 1500)
            {
                impuesto = sueldo * 0.10;
            }
            else if (sueldo <= 3000)
            {
                double adicional = sueldo - 1500; 
                impuesto = adicional * 0.05;
            }
            else
            {
                double adicional = sueldo - 3000;  
                impuesto = adicional * 0.03;  
            }
            sueldoNeto = sueldo - impuesto;
            Console.WriteLine("El impuesto aplicado es: " + impuesto);
            Console.WriteLine("El sueldo neto es: " + sueldoNeto);
        }
    }
}
