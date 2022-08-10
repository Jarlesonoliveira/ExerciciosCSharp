using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exec_1044
{
    internal class Program
    {
        static void Main(string[] args) {

            string[] numeros = Console.ReadLine().Split(' ');

            int A = int.Parse(numeros[0]);
            int B = int.Parse(numeros[1]);

            if (A % B == 0 || B % A == 0)  {
                Console.WriteLine("Sao Multiplos");
            } else {
                Console.WriteLine("Nao sao Multiplos");
            }
        }
    }
}
