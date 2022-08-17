using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exec_1070
{
    internal class Program
    {
        static void Main(string[] args) {

            int x = int.Parse(Console.ReadLine());
            int contagem = x;

            if( x % 2 == 0) {
                contagem++;
                Console.WriteLine(contagem);
                contagem += 2;
                Console.WriteLine(contagem);
                contagem += 2;
                Console.WriteLine(contagem);
                contagem += 2;
                Console.WriteLine(contagem);
                contagem += 2;
                Console.WriteLine(contagem);
                contagem += 2;
                Console.WriteLine(contagem);

            } else {
                Console.WriteLine(x);
                contagem += 2;
                Console.WriteLine(contagem);
                contagem += 2;
                Console.WriteLine(contagem);
                contagem += 2;
                Console.WriteLine(contagem);
                contagem += 2;
                Console.WriteLine(contagem);
                contagem += 2;
                Console.WriteLine(contagem);
            }
        }
    }
}
