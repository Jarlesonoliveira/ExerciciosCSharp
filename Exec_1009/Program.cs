using System;

namespace Exec_1009 {
    class Program {
        static void Main(string[] args) {

            string nome = (Console.ReadLine());
            double salario = double.Parse(Console.ReadLine());
            double montante = double.Parse(Console.ReadLine());

            double resultado;
            resultado = salario + montante * 0.15;

            Console.WriteLine("TOTAL = R$ " + resultado.ToString("F2"));
            Console.ReadKey();
        }
    }
}
