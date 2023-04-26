using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista1Ex8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double a, b;
            Console.WriteLine("Realizando: conversão graus Celsius para Fahrenheit:");
            Console.Write("Digite o valor em graus Celsius:");
            a = double.Parse(Console.ReadLine());

            b = a*1.8+32;
            Console.WriteLine($"A conversão de {a}°C resultou em {b}°F.");

        }
    }
}
