using System;

namespace Atividade6Correção
{
    class Program
    {
        static void Main(string[] args)
        {
            int valor1 = 0;
            int valor2 = 0;
            int resultado;

            resultado = valor1 * valor2;
            Console.WriteLine(valor1 + " x " +valor2 + " = " + resultado); /* concatenação */

            resultado = ++valor1 * ++valor2;
            Console.WriteLine(valor1 + " x " + valor2 + " = " + resultado);

            resultado = valor1 * ++valor2;
            Console.WriteLine("{0} x {1} = {2} ", valor1, valor2, resultado); /* Placeholders, */

            resultado = valor1 * ++valor2;
            Console.WriteLine($"{valor1} x {valor2} = {resultado} "); /* interpolação */

            resultado = valor1 * ++valor2;
            Console.WriteLine($"{valor1} x {valor2} = {resultado} "); /* interpolação */

            resultado = valor1 * ++valor2;
            Console.WriteLine($"{valor1} x {valor2} = {resultado} "); /* interpolação */

            resultado = valor1 * ++valor2;
            Console.WriteLine($"{valor1} x {valor2} = {resultado} "); /* interpolação */

            resultado = valor1 * ++valor2;
            Console.WriteLine($"{valor1} x {valor2} = {resultado} "); /* interpolação */

            resultado = valor1 * ++valor2;
            Console.WriteLine($"{valor1} x {valor2} = {resultado} "); /* interpolação */

            resultado = valor1 * ++valor2;
            Console.WriteLine($"{valor1} x {valor2} = {resultado} "); /* interpolação */

            resultado = valor1 * ++valor2;
            Console.WriteLine($"{valor1} x {valor2} = {resultado} "); /* interpolação */
        }
    }
}
