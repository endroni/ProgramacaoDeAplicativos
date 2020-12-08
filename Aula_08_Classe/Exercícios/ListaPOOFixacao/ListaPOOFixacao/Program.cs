using System;
using System.Globalization;
using System.Collections.Generic;

namespace ListaPOOFixacao
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("|----------------------------------------------|");
            Console.WriteLine("|--LISTA DE EXERCÍCIOS-------------------------|");
            Console.WriteLine("|--1 - Listar 10 livros------------------------|");
            Console.WriteLine("|--2 - Adicionando Bebidas---------------------|");
            Console.WriteLine("|--3 - Empregados------------------------------|");
            Console.WriteLine("|----------------------------------------------|");
            Console.WriteLine("|--ESCOLHA UMA OPÇÃO E PRESSIONE ENTER---------|");
            Console.Write("|--Opção: ");
            int questao = int.Parse(Console.ReadLine());

            Console.Clear();

            switch (questao)
            {
                case 1:
                    List<string> livros = new List<string>();

                    Console.Write("Quantos livros você quer adicionar? ");
                    int n = int.Parse(Console.ReadLine());

                    for (int i = 0; i < n; i++)
                    {
                        Console.Write("Nome do " + (i + 1) + "º livro: ");
                        string nome = Console.ReadLine();
                        livros.Add(nome);
                    }
                    Console.Clear();

                    foreach (string l in livros)
                    {
                        Console.WriteLine(l);
                    }

                    break;

                case 2:

                    Console.Write("Quantas bebidas você deseja adicionar? ");
                    int b = int.Parse(Console.ReadLine());

                    List<Bebida> bebida = new List<Bebida>();

                    for (int i = 0; i < b; i++)
                    {
                        Console.WriteLine("Bebida Nº " + i + 1);
                        Console.Write("Digite o ID: ");
                        int id = int.Parse(Console.ReadLine());
                        Console.Write("Digite o nome: ");
                        string nome = Console.ReadLine();
                        Console.Write("Digite o valor R$ ");
                        double valor = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                        bebida.Add(new Bebida(id, nome, valor));
                        Console.Clear();
                    }

                    foreach (Bebida beb in bebida)
                    {
                        Console.WriteLine(beb);
                    }

                    break;

                case 3:
                    List<Empregado> empregado = new List<Empregado>();

                    Console.Write("Quantos empregados você quer adicionar? ");
                    int emp = int.Parse(Console.ReadLine());

                    for (int i = 0; i < emp; i++)
                    {
                        Console.WriteLine("Empregado #" + i + 1);
                        Console.Write("Id: ");
                        int id = int.Parse(Console.ReadLine());
                        Console.Write("Nome: ");
                        string nome = Console.ReadLine();
                        Console.Write("Salario: ");
                        double salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                        empregado.Add(new Empregado(id, nome, salario));
                    }

                    Console.Write("entre com o id do empregado que terá reajuste de salário: ");
                    int idBusca = int.Parse(Console.ReadLine());

                    // Fazendo uma busca nos Id's dos empregados 
                    Empregado idReajuste = empregado.Find(x => x.IdEmpregado == idBusca);

                    if (idReajuste != null)
                    {
                        Console.Write("Entre com a porcentagem: ");
                        double porcentagem = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                        idReajuste.IncrementarSalario(porcentagem);
                    }
                    else
                    {
                        Console.WriteLine("Id inexistente!");
                    }

                    Console.WriteLine();
                    Console.WriteLine("Lista de empregados atualizada: ");
                    foreach (Empregado obj in empregado)
                    {
                        Console.WriteLine(obj);
                    }
                    break;

                default:
                    Console.WriteLine("|----------------------------------------------|");
                    Console.WriteLine("|--OPÇÃO INVÁLIDA------------------------------|");

                    break;                    
            }
        }
    }
}
