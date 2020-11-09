using System;

namespace Escola
{
    class Program
    {
        static void Main(string[] args)
        {
            string nome = "Rubem";
            string sobrenome = "Cândido";
            int tel = 987655;

            Professor r = new Professor(nome, sobrenome, tel);
            Console.WriteLine(r);
        }
    }
}
