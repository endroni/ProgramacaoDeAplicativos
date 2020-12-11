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
        }
    }
}

