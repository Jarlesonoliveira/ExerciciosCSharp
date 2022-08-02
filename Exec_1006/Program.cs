using System;

namespace Exec_1006 {
    class Program {
        static void Main(string[] args) {
            double NOTAPESO1, NOTAPESO2, MEDIA;

            NOTAPESO1 = Convert.ToDouble(Console.ReadLine());
            NOTAPESO2 = Convert.ToDouble(Console.ReadLine());

            MEDIA = ((NOTAPESO1 * 3.5 + NOTAPESO2 * 7.5) / (3.5 + 7.5));

            Console.WriteLine("MEDIA = " + MEDIA.ToString("F5"));
            Console.ReadLine();
        }
    }
}
