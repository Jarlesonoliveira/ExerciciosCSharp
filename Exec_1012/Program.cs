using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exec_1012
{
    internal class Program
    {
        static void Main(string[] args) {

            double a, b, c, triret, circ, trap, quadr, ret, pi = 3.14159;

            string[] numeros = Console.ReadLine().Split();
             a = double.Parse(numeros[0]);
             b = double.Parse(numeros[1]);
             c = double.Parse(numeros[2]);             

            triret = a * c / 2;
            circ = pi * Math.Pow(c, 2);
            trap = (a + b) * c / 2;
            quadr = b * b;
            ret = a * b;

            Console.WriteLine("TRIANGULO: " + triret.ToString("F3"));
            Console.WriteLine("CIRCULO: " + circ.ToString("F3"));
            Console.WriteLine("TRAPEZIO: " + trap.ToString("F3"));
            Console.WriteLine("QUADRADO: " + quadr.ToString("F3"));
            Console.WriteLine("RETANGULO: " + ret.ToString("F3"));
            Console.ReadKey();
        }
    }
}
