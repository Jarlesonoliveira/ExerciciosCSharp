using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exec_1073
{
    internal class Program
    {
        static void Main(string[] args) {

            int N = int.Parse(Console.ReadLine());
            int numerador = 2;

            while(N >= numerador) {

                Console.WriteLine(numerador + "^2 = " + Math.Pow(numerador, 2));
                numerador += 2;
            }

        }
    }
}
