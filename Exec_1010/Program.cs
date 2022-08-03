using System;

namespace Exec_1010 {
    class Program {
        static void Main(string[] args) {

            string[] produto1 = Console.ReadLine().Split(' ');
            int value1 = int.Parse(produto1[0]);
            int value2 = int.Parse(produto1[1]);
            double value3 = double.Parse(produto1[2]);

            string[] produto2 = Console.ReadLine().Split(' ');
            int value4 = int.Parse(produto2[0]);
            int value5 = int.Parse(produto2[1]);
            double value6 = double.Parse(produto2[2]);

            double Total = (value2 * value3) + (value5 * value6);

            Console.WriteLine("VALOR A PAGAR: R$ {0}", Total.ToString("F2"));
            Console.ReadKey();

        }
    }
}
