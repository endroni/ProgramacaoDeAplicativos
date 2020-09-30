using System;

namespace OperadoresDeAtribuição
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Operadores de atribuição 
              Operador    Exemplo     Significado 
                =       a = 10;         a RECEBE 10 
                +=      a += 2;         a RECEBE a + 2;
                -=      a -= 2;         a RECEBE a - 2;
                *=      a *= 2;         a RECEBE a * 2;
                /= a    /= 2;           a RECEBE a / 2;
                %=      a %= 3;         a RECEBE a % 3;

        Exemplo:
            */
            int a = 10;
            Console.WriteLine(a);
            a += 2;
            Console.WriteLine(a);

            a -= 2;
            Console.WriteLine(a);

            a *= 2;
            Console.WriteLine(a);

            a /= 2;
            Console.WriteLine(a);

            a %= 3;
            Console.WriteLine(a);

            /* Atribuição também funciona com sting */

            string s = "ABC";
            Console.WriteLine(s);

            s += "DEF";
            Console.WriteLine(s);

            /* Operador aritméticos / atribuição
                 Operador     Exemplo         Significado 
                  ++          b++; ou ++b;    b = b + 1; 
                  --          b--; ou --b;    b = b - 1; 

                 Exemplo: */

            int b = 10;
            b++;
            Console.WriteLine(b);

            b--;
            Console.WriteLine(b);

            Console.WriteLine(); /* só para dar um espaço no código */

            int c = 10;
            int d = c++;            /* d recebeu c == 10 */
            Console.WriteLine(c);   /* só depois c foi incrementado */
            Console.WriteLine(d);

            Console.WriteLine();

            int e = 10;
            int f = ++e;                /* e foi incrementado */
            Console.WriteLine(e);       /* depois f recebeu o valor */
            Console.WriteLine(f);
        }
    }
}
