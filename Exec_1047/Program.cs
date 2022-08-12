using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exec_1047
{
    internal class Program
    {
        static void Main(string[] args) {

            string[] vet = Console.ReadLine().Split(' ');

            int horaInicial = int.Parse(vet[0]);
            int minutoInicial = int.Parse(vet[1]);
            int horaFinal = int.Parse(vet[2]);
            int minutoFinal = int.Parse(vet[3]);

            int instanciaInicial = horaInicial * 60 + minutoInicial;
            int instanciaFinal = horaFinal * 60 + minutoFinal;

            int duracao;
            if (instanciaInicial < instanciaFinal) {

                duracao = instanciaFinal - instanciaInicial;

            }else {

                duracao = (24 * 60 - instanciaInicial) + instanciaFinal;

            }

            int duracaoHoras = duracao / 60;
            int duracaoMinutos = duracao % 60;

            Console.WriteLine("O JOGO DUROU " + duracaoHoras + " HORA(S) E " + duracaoMinutos + " MINUTO(S)");
        }
    }
}
