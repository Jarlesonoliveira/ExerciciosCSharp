using System;

namespace Exec_1006 {
    class Program {
        static void Main(string[] args) {
            double NOTAPESO1, NOTAPESO2, NOTAPESO3, MEDIA;

            NOTAPESO1 = Convert.ToDouble(Console.ReadLine());
            NOTAPESO2 = Convert.ToDouble(Console.ReadLine());
            NOTAPESO3 = Convert.ToDouble(Console.ReadLine());

            MEDIA = ((NOTAPESO1 * 2.0 + NOTAPESO2 * 3.0 + NOTAPESO3 * 5.0) /(10));//10 e a soma de todos os pesos

            Console.WriteLine("MEDIA = " + MEDIA.ToString("F1"));
            Console.ReadLine();
        }
    }
}
