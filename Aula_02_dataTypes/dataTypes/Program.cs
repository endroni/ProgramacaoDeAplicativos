using System;
using System.Globalization;

namespace dataTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            sbyte x = 100; /* padrão c# - SByte - padrão .NET*/
            Console.WriteLine(x);

            byte n1 = 254; /* não aceita número negativo */
            n1++;
            Console.WriteLine(n1);

            sbyte n2 = 127;
            n2++;
            Console.WriteLine(n2);

            int n3 = 1000;
            Console.WriteLine(n3);

            int n4 = 2147483647; /* se colocar um 8 no final já dá erro */
            Console.WriteLine(n4);

            long n5 = 2147483648L; /* recomendado colocar o sufixo L no 
                                    * final de um número long */
            Console.WriteLine(n5);

            bool completo = false;
            Console.WriteLine(completo);

            char genero = 'F'; /* para representar caracter 
                                * precisa colocar entre aspas simples */
            Console.WriteLine(genero);

            /*mostrar o unicode */
            char letra = '\u0042'; /*contrabarra no início \ */
            Console.WriteLine(letra);

            float n6 = 5.7f;  /* coloca o f no final para saber que é float */
                                        /* se não ele vai achar que é doble */
                                        /* use o ponto e não a vírgula */
                                        /* português do Brasil */
                                        /* Depois vamos saber como mudar */
            Console.WriteLine(n6);

            double n7 = 8.4;
            Console.WriteLine(n7);

            string nome = "Rubem Santos"; /* Um caracter ' aspas simples */
            /* mais de um caracter " aspas duplas */
            Console.WriteLine(nome);


            /* String não é um tipo básico do c#, por isso não está na tabela */
            /* String - Cadeia de caracteres Unicode */
            /* IMUTÁVEL (segurança, simplicidade, ThreadStaticAttribute safe) */
            /*Iremos trabalhar mais sobre esse assunto */

            nome = "Rubem Cândido";
            Console.WriteLine(nome);

            /* não estamos mudando a string. */
            /* Estamos criando outra string e atribuindo um valor */

            /* Object */
            /* Um objeto genérico (toda classe em C# é subclasse de object) */
            object obj1 = "Wesley Safadão";
            object obj2 = 5.7;
            Console.WriteLine(obj1);
            Console.WriteLine(obj2);

            /* Não precisa decorar os valores */
            int n10 = int.MinValue;
            Console.WriteLine(n10);

            int n11 = int.MaxValue;
            Console.WriteLine(n11);

            sbyte n12 = sbyte.MinValue;
            Console.WriteLine(n12);

            decimal n13 = decimal.MaxValue;
            Console.WriteLine(n13);


            /* Próxima aula - Valor x Tipo de referência */




        }
    }
}
