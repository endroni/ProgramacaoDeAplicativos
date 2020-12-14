using System;
using SobreposicaoVirtualOverrideBase.Entities;

namespace SobreposicaoVirtualOverrideBase
{
    class Program
    {
        static void Main(string[] args)
        {
            Conta conta1 = new Conta(768, "José", 600.0);
            Conta conta2 = new ContaPoupanca(784, "Maria", 600.0, 0.01);

            conta1.Saque(20.0);
            conta2.Saque(20.0);

            Console.WriteLine(conta1.Saldo);
            Console.WriteLine(conta2.Saldo);
        }
    }
}
