using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exec_1064
{
    internal class Program
    {
        static void Main(string[] args) {

            double num1 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double num2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double num3 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double num4 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double num5 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double num6 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            int contagem = 0;
            double somaValor = 0.00;

            if(num1 >= 0.00) {
                contagem += 1;
                somaValor += num1;
            }

            if (num2 >= 0.00) {
                contagem += 1;
                somaValor += num2;
            }

            if (num3 >= 0.00) {
                contagem += 1;
                somaValor += num3;
            }

            if (num4 >= 0.00) {
                contagem += 1;
                somaValor += num4;
            }

            if (num5 >= 0.00) {
                contagem += 1;
                somaValor += num5;
            }

            if (num6 >= 0.00) {
                contagem += 1;
                somaValor += num6;
            }

            double media = somaValor / contagem;

            Console.WriteLine(contagem + " valores positivos", CultureInfo.InvariantCulture);
            Console.WriteLine(media.ToString("F1", CultureInfo.InvariantCulture));
        }
    }
}
