using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exec_1049
{
    internal class Program
    {
        static void Main(string[] args) {

            string VI = Console.ReadLine();
            string AVIA = Console.ReadLine();
            string COHH = Console.ReadLine();

            if(VI == "vertebrado") {
                if(AVIA == "ave") {                    
                    if(COHH == "carnivoro") {
                        Console.WriteLine("aguia");
                    }else if(COHH == "onivoro") {
                        Console.WriteLine("pomba");
                    }
                }else if(AVIA == "mamifero") {
                    if(COHH == "onivoro") {
                        Console.WriteLine("homem");
                    }else if(COHH == "herbivoro") {
                        Console.WriteLine("vaca");
                    }
                }
            }else if (VI == "invertebrado") {
                if(AVIA == "inseto") {
                    if(COHH == "hematofago") {
                        Console.WriteLine("pulga");
                    }else if(COHH == "herbivoro") {
                        Console.WriteLine("lagarta");
                    }
                }else if(AVIA == "anelideo") {
                    if(COHH == "hematofago") {
                        Console.WriteLine("sanguessuga");
                    }else if(COHH == "onivoro") {
                        Console.WriteLine("minhoca");
                    }
                }
            }
        }
    }
}
