using System;

namespace ListaVetores
{
    class Program
    {
        static void Main(string[] args)
        {
            // 1. Crie um programa que leia 6 valores inteiros e, em seguida, mostre na tela os valores lidos.

            int[] vetor = new int[6];
            for (int i = 0; i < 6; i++)
            {
                vetor[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine();
            for(int i = 0; i < 6; i++ )
            {
                Console.WriteLine(vetor[i]);
            }
        }
    }
}
