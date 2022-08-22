using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exec_1080
{
    internal class Program
    {
        static void Main(string[] args) {

            int numero, maior, posicao;

            maior = 0;
            posicao = 0;

            for(int i = 1; i <= 100; i++) {

                numero = int.Parse(Console.ReadLine());

                if(numero > maior) {

                    maior = numero;
                    posicao = i;
                }

            }

            Console.WriteLine(maior);
            Console.WriteLine(posicao);

        }
    }
}
