using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exec_1017
{
    internal class Program
    {
        static void Main(string[] args) {

            int autonomia = 12;
            double horasPercorridas, velocidadeMedia;
            double gastoCombustivel;

            horasPercorridas = double.Parse(Console.ReadLine());
            velocidadeMedia = double.Parse(Console.ReadLine());

            gastoCombustivel = (velocidadeMedia / autonomia) * horasPercorridas;

            Console.WriteLine(gastoCombustivel.ToString("F3"));
            Console.ReadKey();
        }
    }
}
