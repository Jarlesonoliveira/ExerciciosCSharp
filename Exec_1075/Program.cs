﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exec_1075
{
    internal class Program
    {
        static void Main(string[] args) {
            
            int N = int.Parse(Console.ReadLine());

            for(int i = 1; i <= 10000; i++) {

                if(i % N == 2) {
                    Console.WriteLine(i);
                }
            }
        }
    }
}