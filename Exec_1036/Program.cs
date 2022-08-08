using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exec_1036
{
    internal class Program
    {
        static void Main(string[] args) {

            double a, b, c, delta, r1, r2;

            string[] leitura = Console.ReadLine().Split (' ');
            a = double.Parse (leitura[0]);
            b = double.Parse (leitura[1]);
            c = double.Parse (leitura[2]);

            delta = Math.Pow(b, 2.0) - 4 * a * c;

            if ( a == 0 || delta < 0 ) {

                Console.WriteLine("Impossivel calcular");

            } else {

                r1 = ( -b + Math.Sqrt (delta)) / (2.0 * a);
                r2 = ( -b - Math.Sqrt (delta)) / (2.0 * a);

                Console.WriteLine("R1 = " + r1.ToString("F5"));
                Console.WriteLine("R1 = " + r2.ToString("F5"));
            }
        }
    }
}
