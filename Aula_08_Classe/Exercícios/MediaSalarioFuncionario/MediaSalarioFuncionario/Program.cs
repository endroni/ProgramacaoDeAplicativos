using System;
using System.Globalization;

namespace MediaSalarioFuncionario
{
    class Program
    {
        static void Main(string[] args)
        {
            SalarioMedio funcionario1 = new SalarioMedio();
            SalarioMedio funcionario2 = new SalarioMedio();

            Console.WriteLine("Dados do primeiro funcionário: ");
            Console.Write("Nome: ");
            funcionario1.Nome = Console.ReadLine();
            Console.Write("Salário: ");
            funcionario1.Salario = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);

            Console.WriteLine("Dados do segundo funcionário: ");
            Console.Write("Nome: ");
            funcionario2.Nome = Console.ReadLine();
            Console.Write("Salário: ");
            funcionario2.Salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double media = (funcionario1.Salario + funcionario2.Salario) / 2;

            Console.Write($"Salário médio = {media.ToString("F2", CultureInfo.InvariantCulture)}");

            Console.ReadKey();
        }
    }
}
