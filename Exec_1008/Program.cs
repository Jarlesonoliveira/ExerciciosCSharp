using System;

namespace Exec_1008 {
    class Program {
        static void Main(string[] args) {
            int funcionario;
            int horas;
            decimal valor;


            funcionario = int.Parse(Console.ReadLine());
            horas = int.Parse(Console.ReadLine());
            valor = decimal.Parse(Console.ReadLine().Replace(".", ","));

            decimal salario = valor * horas;

            Console.WriteLine("NÚMERO = " + funcionario);
            Console.WriteLine("SALÁRIO = U$ " + salario.ToString().Replace(",", "."));
            Console.ReadKey();
        }
    }
}
