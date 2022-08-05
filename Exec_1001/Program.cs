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
            double area, n, raio;
            n = 3.14159;

            raio = double.Parse(Console.ReadLine());
            area = n * (raio * raio);

            Console.WriteLine("A=" + area.ToString("F4"));
        }
    }
}
