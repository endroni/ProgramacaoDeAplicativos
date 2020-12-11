using System;
using UpcastingDowncasting.Entities;

namespace UpcastingDowncasting
{
    class Program
    {
        static void Main(string[] args)
        {
            Conta conta = new Conta(101, "Jiraya", 0.0);
            ContaEmpresa empresa = new ContaEmpresa(1001, "Kurama", 0.0, 400.0);

            //UPCASTING 
            Conta conta2 = empresa;
            Conta conta3 = new ContaEmpresa(1002, "Kakashi", 0.0, 300.0);
            Conta conta4 = new ContaPoupanca(2001, "Hinata", 0.0, 0.01);

            // DOWNCASTING

            ContaEmpresa conta5 = (ContaEmpresa)conta3;
            conta5.Emprestimo(200.0);

            // ContaEmpresa conta6 = (ContaEmpresa)conta4;

            if ( conta4 is ContaEmpresa)
            {
                //ContaEmpresa conta6 = (ContaEmpresa)conta4;
                ContaEmpresa conta6 = conta4 as ContaEmpresa;  // Opção - as
                conta6.Emprestimo(150.0);
                Console.WriteLine("Emprestimo realizado com sucesso!");
            }

            if (conta4 is ContaPoupanca)
            {
                // ContaPoupanca conta6 = (ContaPoupanca)conta4;
                ContaPoupanca conta6 = conta4 as ContaPoupanca; // Opção - as
                conta6.AtualizaSaldo();
                Console.WriteLine("Poupança rendeu juros!");
            }
        }
    }
}

