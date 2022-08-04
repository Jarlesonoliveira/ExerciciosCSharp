using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exec_1014
{
    internal class Program
    {
        static void Main(string[] args) {

            int X = int.Parse(Console.ReadLine());
            double Y = double.Parse(Console.ReadLine());

            double klm = X / Y;

            Console.WriteLine($"{klm.ToString("F3")} km/l");
            Console.ReadKey();
        }
    }
}
