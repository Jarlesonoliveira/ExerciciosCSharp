using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exec_1020
{
    internal class Program
    {
        static void Main(string[] args) {

            int quociente, idade, resto;
            int ano = 365;
            int mes = 30;

            idade = int.Parse(Console.ReadLine());

            quociente = idade / ano;
            Console.WriteLine(quociente + " ano(s)");
            resto = idade % ano;

            quociente = resto / mes;
            Console.WriteLine(quociente + " mes(es)");
            resto = resto % mes;

            Console.WriteLine(resto + " dia(s)");
            Console.ReadKey();
        }
    }
}
