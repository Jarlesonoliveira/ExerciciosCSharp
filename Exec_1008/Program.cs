using System;
using System.Globalization;

namespace Exec_1008 {
    class Program {
        static void Main(string[] args) {
            //using System.Globalization; | CultureInfo.InvariantCulture);
            //Para modificar para 550,00
            int funcionario;
            int horas;
            decimal valor;

            System.Globalization.CultureInfo customCulture = (System.Globalization.CultureInfo)System.Threading.Thread.CurrentThread.CurrentCulture.Clone();

            customCulture.NumberFormat.NumberDecimalSeparator = ".";

            System.Threading.Thread.CurrentThread.CurrentCulture = customCulture;



            funcionario = int.Parse(Console.ReadLine());
            horas = int.Parse(Console.ReadLine());
            valor = decimal.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            decimal salario = valor * horas;

            Console.WriteLine("NÚMERO = " + funcionario);
            Console.WriteLine("SALÁRIO = U$ " + String.Format("{0:0.00}", salario), CultureInfo.InvariantCulture);
            Console.ReadKey();
        }
    }
}
