using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exec_1074
{
    internal class Program
    {
        static void Main(string[] args) {

            int N = int.Parse(Console.ReadLine());
            int X;

            for(int i = 0; i < N; i++) {
                X = int.Parse(Console.ReadLine());
                if(X == 0) {
                    Console.WriteLine("NULL");
                }else if(X < 0) {
                    if(X % 2 == 0) {
                        Console.WriteLine("EVEN NEGATIVE");
                    } else {
                        Console.WriteLine("ODD NEGATIVE");
                    }
                } else {
                    if(X % 2 == 0) {
                        Console.WriteLine("EVEN POSITIVE");
                    } else {
                        Console.WriteLine("ODD POSITIVE");
                    }
                }
            }

        }
    }
}
