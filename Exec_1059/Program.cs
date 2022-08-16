using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exec_1059
{
    internal class Program
    {
        static void Main(string[] args) {

            int numPar = 1;

            while(numPar <= 100) {

                if (numPar % 2 == 0) {

                    Console.WriteLine(numPar);
                } 
                numPar++;
            }
        }
    }
}
