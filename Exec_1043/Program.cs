using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exec_1043
{
    internal class Program
    {
        static void Main(string[] args) {

            string[] numeros = Console.ReadLine().Split(' ');
            double A = double.Parse(numeros[0], CultureInfo.InvariantCulture);
            double B = double.Parse(numeros[1], CultureInfo.InvariantCulture);
            double C = double.Parse(numeros[2], CultureInfo.InvariantCulture);

            if (A < B + C && A > Math.Abs(B - C)) {
                double perimetro = A + B + C;
                Console.WriteLine("Perimetro = " + perimetro.ToString("F1", CultureInfo.InvariantCulture));
            } else {
                double area = (A + B) / 2.0 * C;
                Console.WriteLine("Area = " + area.ToString("F1", CultureInfo.InvariantCulture));
            }
        }
    }
}
