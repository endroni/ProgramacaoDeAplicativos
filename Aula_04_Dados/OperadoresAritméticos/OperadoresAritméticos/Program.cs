using System;

namespace OperadoresAritméticos
{
    class Program
    {
        static void Main(string[] args)
        {
            /* 
                Operadores aritméticos
                
                Operador    Significado
                    +       adiçaõ                      (menor precedencia)
                    -       subtração                   (menor precedencia)

                    *       multiplicação               (maior precedencia)
                    /       divisão                     (maior precedencia)
                    %       resto da divisão (mode)     (maior precedencia)

                                                        ( ) Parenteses quebra precedencia

            Exemplos:
            */

            int n1 = 3 + 4 * 2;
            Console.WriteLine(n1);

            int n2 = (3 + 4) * 2;
            Console.WriteLine(n2);

            int n3 = 17 % 3;
            Console.WriteLine(n3);

            int n4 = 10 / 8;
            Console.WriteLine(n4);

            double n5 = 10 / 8;
            Console.WriteLine(n5);

            /* 1ª Opção */
            double n6 = (double)10 / 8;
            Console.WriteLine(n6);

            /* 2ª Opção */
            double n7 = 10.0 / 8; 
            Console.WriteLine(n7);

            /* Fazendo calculo de bhaskara */

            double a = 1.0, b = -3.0, c = -4.0;

            /* double delta = b * b - 4.0 * a * c;  */

            /* expressão aritmética para delta */


            /* Podemos utilizar uma função matemática Math.Pow */

            double delta = Math.Pow(b, 2.0) - 4.0 * a * c;

            double x1 = ((-b + Math.Sqrt(delta)) / (2.0 * a));
            double x2 = ((-b - Math.Sqrt(delta)) / (2.0 * a));

            Console.WriteLine(delta);
            Console.WriteLine(x1);
            Console.WriteLine(x2);

            Console.WriteLine();

            double cubo = 2 * 2 * 2;
            Console.WriteLine(cubo);
            double cubo2 = Math.Pow(2.0, 3.0);
            Console.WriteLine(cubo2);

        }
    }
}
