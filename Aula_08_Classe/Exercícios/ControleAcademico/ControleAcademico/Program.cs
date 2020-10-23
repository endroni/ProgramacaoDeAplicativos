using System;
using System.Globalization;

namespace ControleAcademico
{
    class Program
    {
        static void Main(string[] args)
        {
            Aluno a = new Aluno();

            Console.Write("Nome do aluno: ");
            a.Nome = Console.ReadLine();

            Console.WriteLine("Digite as três notas do aluno:");
            a.Nota1 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            a.Nota2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            a.Nota3 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double total = a.NotaFinal();

            Console.WriteLine("NOTA FINAL = " + total.ToString("F2", CultureInfo.InvariantCulture));

            if ( total >= 60 )
            {
                Console.WriteLine("APROVADO");
            }
            else
            {
                Console.WriteLine("REPROVADO");
                Console.WriteLine("FALTARAM " + (60 - total).ToString("F2", CultureInfo.InvariantCulture) + " PONTOS" );
            }
        }
    }
}
