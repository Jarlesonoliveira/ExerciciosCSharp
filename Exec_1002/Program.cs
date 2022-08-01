using System;

namespace Exec_1002 {
    class Program {
        static void Main(string[] args) {

            double pi = 3.14159;
            double raio = Convert.ToDouble(Console.ReadLine());
            double area = pi * Math.Pow(raio, 2);

            Console.WriteLine($"A={area:F4}");
        }
    }
}
