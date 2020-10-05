using System;

namespace estruturaCondicional
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Estrutura Condicional Simples 
                
            if ( condição ) {
                comando 1
                comando 2
            }

            Exemplo:    */
            int x = 3;

            if (x % 2 == 0)
            {
                Console.WriteLine("Número par!");
            }

            /* Estrura Condicional Composta
            
            if ( condição ) {
                comando 1
                comando 2
            } 
            else {
                comando 3
                comando 4
            }

            Exemplo:    */

            int y = 3;

            if (y % 2 == 0)
            {
                Console.WriteLine("Número par!");
            }
            else
            {
                Console.WriteLine("Número impar!");
            }

            /* Estrutura condicional Encadeada ou aninhada 
            
            if ( condição 1 ) {
                comando 1
                comando 2
            }
            esle if ( condição 2 ) {
                comando 3
                comando 4
            }
            else if ( condição 3 ) {
                comando 5
                comando 6
            }
            else {
                comando 7
                comando 8
            }   

            Exemplo:    */

            int hora = int.Parse(Console.ReadLine());

            if ( hora < 12 )
            {
                Console.WriteLine("Bom dia!");
            } 
            else if ( hora < 18 )
            {
                Console.WriteLine("Boa tarde!");
            }
            else
            {
                Console.WriteLine("Boa noite!");
            }
        }
    }
}
