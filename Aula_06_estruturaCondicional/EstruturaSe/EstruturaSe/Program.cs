using System;
using System.Linq;

namespace EstruturaSe
{
    class Program
    {
        static void Main(string[] args)
        {
            bool atividade = true;
            bool dinheiro = false;

            if (atividade == true)
            {
                Console.WriteLine("Sextou atividades");
            } 
            else if ( atividade == false && dinheiro == true)
            {
                Console.WriteLine("Vou namorar!");
            }
            else
            {
                Console.WriteLine("Jogar ...");
            }
        }
    }
}
