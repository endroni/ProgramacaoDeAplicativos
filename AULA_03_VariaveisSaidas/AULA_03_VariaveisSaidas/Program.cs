using System;
using System.Globalization;

namespace AULA_03_VariaveisSaidas
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Restrições para nomes de variáveis */
            /* Não pode começar com números: use uma letra ou _ */
            /* Não use acentos ou ç */
            /* Não pode ter espaço em branco */
            /* Sugestão: use nomes que tenham um significado */
            /* Formas incorretas para variáveis: 
             int 5minutos;
             int salário;
             int salario do funcionario; */

            /* Formas corretas: 
            int _5minutos;
            int salario;
            int salarioDoFuncionario; 

            Vamos combinar de usar camelCase 
                com a primeira letra minúscula para 
                variáveis 
            */

            /* Imprimir na saída padrão (console ) 
            
            Console.WriteLine( valor ); - Quebra de linha
            escrevaL 
            Console.Write ( valor );
            escreva
            */

            Console.Write("Bom dia!");
            Console.WriteLine("Boa tare!");
            Console.WriteLine("Boa noite!");
            Console.WriteLine("********-------**********");

            /* Imprimindo variáveis */

            char genero = 'F';
            int idade = 26;
            double saldo = 5.343678;
            string nome = "Francesca";

            Console.WriteLine(genero);
            Console.WriteLine(idade);
            Console.WriteLine(saldo);
            Console.WriteLine(nome);

            /*Controlando quantidade de casas decimais */
            Console.WriteLine(saldo.ToString("F2"));
            Console.WriteLine(saldo.ToString("F3"));
            /*Arredondamento */

            /* Para mudar a vírgula para ponto FormatProvider*/
            double combustivel = 4.29876;
            Console.WriteLine(combustivel.ToString("F2",CultureInfo.InvariantCulture));
            Console.WriteLine("");
            Console.WriteLine("---------------================-------------");

            string funcionario = "João";
            int telefone = 99887766;
            double salario = 4.354;

            Console.Write("O telefone do ");
            Console.Write(funcionario);
            Console.Write(" é ");
            Console.Write(telefone);
            Console.Write(" e ele recebe R$ ");
            Console.Write(salario.ToString("F2",CultureInfo.InvariantCulture));
            Console.Write(" reais");
            Console.WriteLine("");
            Console.WriteLine("---------==============--------------");

            /* Não é muito prático. Muito verboso */

            /* Placehosders */
            Console.WriteLine("O telefone do {0} é {1} e ele recebe R$ {2:F2} reais", funcionario, telefone, salario);

            /* interpolação - Versão 6 do C# em diante */
            Console.WriteLine($"O telefone do {funcionario} é {telefone} e ele recebe R$ {salario:F2} reais");

            /*Concatenação - a mais antiga */
            Console.WriteLine("O telefone do " + funcionario + " é " + telefone + " e ele recebe R$ " + salario.ToString("F2",CultureInfo.InvariantCulture) + " reais");

            /*Para mudar o formato de pontuação, só 
             com o ToString */
        }
    }
}
