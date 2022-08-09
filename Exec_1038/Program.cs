using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exec_1038
{
    internal class Program
    {
        static void Main(string[] args) {

            string[] leitura = Console.ReadLine().Split(' ');
            string item = (leitura[0]);
            int quantidade = int.Parse(leitura[1]);

            if (item == "1")
            {
                Console.WriteLine("Total: R$ " + (quantidade * 4.00).ToString("F2"));
            } 
            else if (item == "2")
            {
                Console.WriteLine("Total: R$ " + (quantidade * 4.50).ToString("F2"));
            } 
            else if (item == "3") 
            {
                Console.WriteLine("Total: R$ " + (quantidade * 5.00).ToString("F2"));
            } 
            else if (item == "4")
            {
                Console.WriteLine("Total: R$ " + (quantidade * 2.00).ToString("F2"));
            } 
            else if (item == "5") 
            {
                Console.WriteLine("Total: R$ " + (quantidade * 1.50).ToString("F2"));
            }            
        }
    }
}
