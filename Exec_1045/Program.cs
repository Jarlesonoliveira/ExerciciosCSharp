using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace Exec_1045
{
    internal class Program
    {
        static void Main(string[] args) {

            double A, B, C;

            string[] vet = Console.ReadLine().Split(' ');

            float numOne = float.Parse(vet[0], CultureInfo.InvariantCulture);
            float numTwo = float.Parse(vet[1], CultureInfo.InvariantCulture);
            float numThree = float.Parse(vet[2], CultureInfo.InvariantCulture);

            if (Math.Max(numOne, numTwo) > numThree) {

                A = Math.Max(numOne, numTwo);
                if (A > Math.Max(numTwo, numThree)) {

                    B = Math.Max(numTwo, numThree);
                    C = Math.Min(numTwo, numThree);
                } else {

                    B = Math.Max(numOne, numThree);
                    C = Math.Min(numOne, numThree);
                }
            } else {

                A = numThree;
                B = Math.Max(numOne, numTwo);
                C = Math.Min(numOne, numTwo);
            }

            if (A >= B + C) {
                Console.WriteLine("NAO FORMA TRIANGULO");

            } else {

                if (Math.Pow(A, 2) == Math.Pow(B, 2) + Math.Pow(C, 2)) {

                    Console.WriteLine("TRIANGULO RETANGULO");

                } else if (Math.Pow(A, 2) > Math.Pow(B, 2) + Math.Pow(C, 2)) {

                    Console.WriteLine("TRIANGULO OBTUSANGULO");

                } else {

                    Console.WriteLine("TRIANGULO ACUTANGULO");

                }

                if (A == B && B == C) {

                    Console.WriteLine("TRIANGULO EQUILATERO");

                } else if (A == B || A == C || B == C) {

                    Console.WriteLine("TRIANGULO ISOSCELES");

                }
            }
        }
    }
}
