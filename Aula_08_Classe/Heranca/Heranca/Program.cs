using System;
using Heranca.Entiites;

namespace Heranca
{
    class Program
    {
        static void Main(string[] args)
        {
            ContaEmpresa conta = new ContaEmpresa(9015, "Naruto", 200.0, 500.0);
            Console.WriteLine( conta.Saldo );

            // conta.Saldo = 300.0;
        }
    }
}


