using System;

namespace ConversaoValores
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Conversão implícita entre tipos */

            float x = 7.5f; /* Float - Tamanho de 4 bytes */

            double y = x;    /* Double - Tamanho de 8 bytes */

            Console.WriteLine(y);

            /* 
                Ocorreu uma conversão implícita de dados, 
                porque y recebeu perfeitamente o valor de x,
                é possível por causa do tamanho em bytes. 

             */

            double a;
            float b;

            a = 5.1;
            b = (float)a;
            Console.WriteLine(b);

            /* 
               Como double tem 8 bytes e float tem 4 bytes. 
               O compilador avisa: Dados podem ser perdidos 
               para isso precisamos fazer uma 
               conversão explicita de tipos 
             */

            double c;
            int d;
            c = 6.1;
            d = (int)c;

            Console.WriteLine(d);
            /* 
                Nesse caso o compilador avisa que podemos 
                perder dados por causa do tipo do dado 
                
                Valores truncados = Quando perdemos parte do dado
            */

            int e = 5;
            int f = 2;

            double resultado = (double)e / f;

            Console.WriteLine(resultado);

            /* Como os valores de e , f são inteiros. 
               O compilador achou que eu queria uma divisão inteira. 
               Para alterar o resultado. Precisamos fazer um casting

               double resultado = (double) e / f ;
            */
        }
    }
}
