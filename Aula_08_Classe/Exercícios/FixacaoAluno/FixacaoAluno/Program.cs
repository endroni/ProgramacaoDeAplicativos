using System;

namespace FixacaoAluno
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bem vindo ao sistema escola");
            Console.WriteLine("Essa escola só permite alunos residentes da cidade de Belo Horizonte");
            Console.Write("Entre com seu nome: ");
            string nome = Console.ReadLine();

            Console.Write("Entre com seu telefone: ");
            int telefone = int.Parse(Console.ReadLine());

            Aluno aluno = new Aluno(nome, telefone);

            Console.WriteLine(aluno);

            Console.ReadKey();
        }
    }
}
