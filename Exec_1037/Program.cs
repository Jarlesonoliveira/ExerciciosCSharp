using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exec_1037
{
    internal class Program
    {
        static void Main(string[] args) {

            double numeroEntrada = double.Parse(Console.ReadLine());

            if (numeroEntrada >= 0 && numeroEntrada <= 25) {

                Console.WriteLine("Intervalo [0,25]");

            } else if (numeroEntrada > 25 && numeroEntrada <= 50) {

                Console.WriteLine("Intervalo (25,50]");

            } else if (numeroEntrada > 50 && numeroEntrada <= 75) {

                Console.WriteLine("Intervalo (50,75]");

            } else if (numeroEntrada > 75 && numeroEntrada <= 100) {

                Console.WriteLine("Intervalo (75,100]");

            } else {

                Console.WriteLine("Fora de intervalo");

            }
        }
    }
}
