using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exec_1013
{
    internal class Program
    {
        static void Main(string[] args) {
            int a, b, c;

            string[] numeros = Console.ReadLine().Split();
            a = int.Parse(numeros[0]);
            b = int.Parse(numeros[1]);
            c = int.Parse(numeros[2]);

            int MaiorAB = (a + b + Math.Abs(a - b)) / 2;

            if (MaiorAB > c) {
                Console.WriteLine($"{MaiorAB} eh o maior");
            } else {
                Console.WriteLine($"{c} eh o maior");
            }
            Console.ReadKey();
        }
    }
}
