using System;

namespace MatizExercicioFixação
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int[,] matriz = new int[n, n];

            for (int i = 0; i < n; i ++)
            {
                string[] valores = Console.ReadLine().Split(' ');

                for (int j = 0; j < n; j++)
                {
                    matriz[i, j] = int.Parse(valores[j]);
                }
            }

            Console.WriteLine("Diagonal principal:");
            for ( int i = 0; i < n; i++ )
            {
                Console.Write(matriz[i,i] + " ");
            }
            
            Console.WriteLine();

            int negativos = 0;

            for ( int i = 0; i < n; i++ )
            {
                for (int j = 0; j < n; j++ ) { 
                    if (matriz[i,j] < 0)
                    {
                        negativos++;
                    }
                }
            }

            Console.Write("Números negativos = " + negativos);
            Console.WriteLine();
         
        }
    }
}
