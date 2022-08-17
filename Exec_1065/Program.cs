using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exec_1065
{
    internal class Program
    {
        static void Main(string[] args) {

            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());
            int num3 = int.Parse(Console.ReadLine());
            int num4 = int.Parse(Console.ReadLine());
            int num5 = int.Parse(Console.ReadLine());


            int contagem = 0;

            if (num1 % 2 == 0.00) {
                contagem += 1;                
            }

            if (num2 % 2 == 0.00) {
                contagem += 1;                
            }

            if (num3 % 2 == 0.00) {
                contagem += 1;                
            }

            if (num4 % 2 == 0.00) {
                contagem += 1;                
            }

            if (num5 % 2 == 0.00) {
                contagem += 1;                
            }

            Console.WriteLine(contagem + " valores pares");
            
        }
    }
}
