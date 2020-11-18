using System;
using System.Globalization;

namespace ControleDeEstoque
{
    class Program
    {
        static void Main(string[] args)
        {
            Produto p = new Produto("TV nome antigo", 500.00, 10);

            p.Nome = "TV novo nome";

            Console.WriteLine(p.Nome);
            Console.WriteLine(p.Preco);
        }
    }
}
