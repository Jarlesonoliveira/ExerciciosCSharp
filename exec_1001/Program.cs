using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exec_1001
{
    internal class Program
    {
        static void Main(string[] args) {
            int A = Convert.ToInt32(Console.ReadLine());
            int B = Convert.ToInt32(Console.ReadLine());
            int X = A + B;

            Console.WriteLine("X = " + X);
            Console.ReadKey();
        }
    }
}
