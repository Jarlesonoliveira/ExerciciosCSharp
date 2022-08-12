using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace Exec_1048
{
    internal class Program
    {
        static void Main(string[] args) {

            double salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            int porcentagem;
            double reajuste;
            
            if (salario >= 0 && salario <= 400.00) {

                porcentagem = 15;
                reajuste = (salario * porcentagem) / 100.00;
                Console.WriteLine("Novo salario: " + (salario + reajuste).ToString("F2", CultureInfo.InvariantCulture));
                Console.WriteLine("Reajuste ganho: " + reajuste.ToString("F2", CultureInfo.InvariantCulture));
                Console.WriteLine("Em percentual: " + porcentagem + " %");

            }else if(salario >= 400.01 && salario <= 800.00 ) {

                porcentagem = 12;
                reajuste = (salario * porcentagem) / 100.00;
                Console.WriteLine("Novo salario: " + (salario + reajuste).ToString("F2", CultureInfo.InvariantCulture));
                Console.WriteLine("Reajuste ganho: " + reajuste.ToString("F2", CultureInfo.InvariantCulture));
                Console.WriteLine("Em percentual: " + porcentagem + " %");

            }else if(salario >= 800.01 && salario <= 1200.01) {

                porcentagem = 10;
                reajuste = (salario * porcentagem) / 100.00;
                Console.WriteLine("Novo salario: " + (salario + reajuste).ToString("F2", CultureInfo.InvariantCulture));
                Console.WriteLine("Reajuste ganho: " + reajuste.ToString("F2", CultureInfo.InvariantCulture));
                Console.WriteLine("Em percentual: " + porcentagem + " %");

            }else if (salario >= 1200.01 && salario <= 2000.00) {

                porcentagem = 7;
                reajuste = (salario * porcentagem) / 100.00;
                Console.WriteLine("Novo salario: " + (salario + reajuste).ToString("F2", CultureInfo.InvariantCulture));
                Console.WriteLine("Reajuste ganho: " + reajuste.ToString("F2", CultureInfo.InvariantCulture));
                Console.WriteLine("Em percentual: " + porcentagem + " %");

            }else {

                porcentagem = 4;
                reajuste = (salario * porcentagem) / 100.00;
                Console.WriteLine("Novo salario: " + (salario + reajuste).ToString("F2", CultureInfo.InvariantCulture));
                Console.WriteLine("Reajuste ganho: " + reajuste.ToString("F2", CultureInfo.InvariantCulture));
                Console.WriteLine("Em percentual: " + porcentagem + " %");

            }

        }
    }
}
