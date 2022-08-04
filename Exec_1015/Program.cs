using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exec_1015
{
    internal class Program
    {
        static void Main(string[] args) {

            double X1, Y1, X2, Y2, soma, distancia;

            string[] P1 = Console.ReadLine().Split(' ');
            X1 = double.Parse(P1[0]);
            Y1 = double.Parse(P1[1]);

            string[] P2 = Console.ReadLine().Split(' ');
            X2 = double.Parse(P2[0]);
            Y2 = double.Parse(P2[1]);

            soma = ((X2 - X1)*(X2 - X1)+ (Y2 - Y1)*(Y2 - Y1));
            distancia = Math.Sqrt(soma);

            Console.WriteLine(distancia.ToString("F4"));
            Console.ReadKey();
        }
    }
}
