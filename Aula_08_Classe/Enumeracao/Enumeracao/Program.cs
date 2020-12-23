using System;
using Enumeracao.Entities;
using Enumeracao.Entities.Enums;

namespace Enumeracao
{
    class Program
    {
        static void Main(string[] args)
        {
            Pedido pedido = new Pedido
            {
                Id = 107,
                Instante = DateTime.Now,
                Status = EstadoPedido.PagamentoPendente
            };

            Console.WriteLine(pedido);

            // Convertendo tipo enumerado para string
            string txt = EstadoPedido.PagamentoPendente.ToString();
                        
            Console.WriteLine(txt);
        }
    }
}
