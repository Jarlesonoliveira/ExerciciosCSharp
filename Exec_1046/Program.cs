using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exec_1046
{
    internal class Program
    {
        static void Main(string[] args) {

            string[] vet = Console.ReadLine().Split(' ');

            int horaInicial = int.Parse(vet[0]);
            int horaFinal = int.Parse(vet[1]);
            int calculoHoraInicial, calculoHoraFinal, calculoTempoEvento = 0;

            if(horaFinal < horaInicial) {

                calculoHoraInicial = 24 - horaInicial;
                calculoHoraFinal = horaFinal;
                calculoTempoEvento = calculoHoraInicial + calculoHoraFinal;

            }

            if(horaInicial == horaFinal) {

                calculoTempoEvento = 24;

            }

            if(horaFinal > horaInicial) {

                calculoHoraInicial = 24 - horaInicial;
                calculoHoraFinal = horaFinal - 24;
                calculoTempoEvento = calculoHoraInicial + calculoHoraFinal;

            }

            Console.WriteLine("O JOGO DUROU " + calculoTempoEvento + " HORA(S)");
        }
    }
}
