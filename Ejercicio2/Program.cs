using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingresa un número entero:");
            string numero = Console.ReadLine();
            int suma = 0;
            for (int i = 0; i < numero.Length; i++)
            {
                if (char.IsDigit(numero[i]))
                {
                    suma += int.Parse(numero[i].ToString()); 
                }
            }
            Console.WriteLine("La suma de los números es: " + suma);
            Console.ReadKey();
        }
    }
}
