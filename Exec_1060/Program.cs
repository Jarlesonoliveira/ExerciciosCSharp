using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exec_1060
{
    internal class Program
    {
        static void Main(string[] args) {
                        
            double num1 = double.Parse(Console.ReadLine());
            double num2 = double.Parse(Console.ReadLine());
            double num3 = double.Parse(Console.ReadLine());
            double num4 = double.Parse(Console.ReadLine());
            double num5 = double.Parse(Console.ReadLine());
            double num6 = double.Parse(Console.ReadLine());

            int valorPositivo = 0;

            if (num1 > 0.00) {
                valorPositivo += 1;
            }

            if (num2 > 0.00) {
                valorPositivo += 1;
            }

            if (num3 > 0.00) {
                valorPositivo += 1;
            }

            if (num4 > 0.00) {
                valorPositivo += 1;
            }

            if (num5 > 0.00) {
                valorPositivo += 1;
            }

            if (num6 > 0.00) {
                valorPositivo += 1;
            }

            Console.WriteLine(valorPositivo + " valores positivos");
        }
    }
}
