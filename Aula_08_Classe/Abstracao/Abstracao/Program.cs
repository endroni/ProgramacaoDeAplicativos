using System;
using System.Collections.Generic;
using System.Globalization;
using Abstracao.Entities;

namespace Abstracao
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Conta> lista = new List<Conta>();

            lista.Add(new ContaPoupanca(15, "Yan", 500.0, 0.01));
            lista.Add(new ContaEmpresa(16, "Yuri", 500.0, 400.0));
            lista.Add(new ContaPoupanca(17, "Carlos", 500.0, 0.01));
            lista.Add(new ContaEmpresa(18, "Barbara", 500.0, 500.0));

            double soma = 0.0;
            foreach (Conta contas in lista)
            {
                soma += contas.Saldo;
            }

            Console.WriteLine("Total do osaldo: " + soma.ToString("F2", CultureInfo.InvariantCulture));

            foreach (Conta contas in lista)
            {
                contas.Saque(10.0);
            }

            foreach (Conta contas in lista)
            {
                Console.WriteLine("Saldo atualizado " 
                    + contas.Numero 
                    + ": "
                    + contas.Saldo.ToString("F2",CultureInfo.InvariantCulture));
            }
        }
    }
}

