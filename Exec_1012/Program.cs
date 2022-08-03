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

            double A = double.Parse(Console.ReadLine());
            double B = double.Parse(Console.ReadLine());
            double C = double.Parse(Console.ReadLine());

            double resultado;
            resultado = A * B * C;

            Console.WriteLine("TOTAL = R$ " + resultado.ToString("F2"));
            Console.ReadKey();
        }
    }
}
