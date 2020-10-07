using System;

namespace Exercicios30_09_2020
{
    class Program
    {
        static void Main(string[] args)
        {
            /* 6 ) Atribua um valor a uma variável 
             do tipo inteiro e exiba seu antecessor. */

            int n1 = 5;
            n1--;
            Console.WriteLine(n1);

            /* 7 ) Atribua um valor a uma variável 
             do tipo inteiro e exiba seu sucessor. */
            int n2 = 36;
            n2++;
            Console.WriteLine(n2);

            /* 10 ) Verifique na internet quanto 
               está valendo o bitcoin e converta 
               R$ 300,00 para bitcoin. */
            double n3 = 300 / 59742.66;
            Console.WriteLine(n3);

            /* 11 ) Faça um programa que calcule 
              a raiz quadrada de 64. */

            /* O Math é um método que trata de questões matemáticas */
            double n4 = Math.Sqrt(64);
            Console.WriteLine(n4);

            /* 12 ) Faça um programa que calcule a 
              potencia de 2 elevado a 128 */
            double n5 = Math.Pow(2, 128);
            Console.WriteLine(n5);

        }
    }
}
