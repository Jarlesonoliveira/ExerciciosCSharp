using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exec_1051
{
    internal class Program
    {
        static void Main(string[] args) {

            double salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double resto = 0.00, calculo = 0.00;

            if (salario >= 0.00 && salario <= 2000.00) {

                Console.WriteLine("Isento");

            } else {
                
                if(salario >= 2000.01 && salario <= 3000.00) {

                    salario += - 2000.00;
                    calculo = salario * 8.00 / 100.00;

                }else if(salario >= 3000.01 && salario <= 4500.00) {

                    resto = 1000.00;
                    calculo = resto * 8.00 / 100.00;
                    salario = salario - 3000.00;
                    calculo += ((salario * 18.00) / 100.00);
                    

                } else {

                    resto = 1000.00;
                    calculo = resto * 8.00 / 100.00;                                     
                    resto = 1500.00;
                    calculo += ((resto * 18.00) / 100.00);
                    salario = salario - 4500.00;
                    calculo += ((salario * 28.00) / 100.00);

                }

                Console.WriteLine("R$ " + calculo.ToString("F2", CultureInfo.InvariantCulture));
            }
        }
    }
}
