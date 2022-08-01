using System;

namespace Exec_1004 {
    class Program {
        static void Main(string[] args) {
            int PROD, a, b;

            a = Int32.Parse(Console.ReadLine());
            b = Int32.Parse(Console.ReadLine());

            PROD = a * b;

            Console.WriteLine("PROD = " + PROD);
            Console.ReadKey();
        }
    }
}
