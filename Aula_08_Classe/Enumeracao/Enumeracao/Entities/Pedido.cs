using System;
using Enumeracao.Entities.Enums;

namespace Enumeracao.Entities
{
    class Pedido
    {
        public int Id { get; set; }
        public DateTime Instante { get; set; }
        public EstadoPedido Status { get; set; }

        public override string ToString()
        {
            return Id 
                + ", "
                + Instante
                + ", "
                + Status; 
        }
    }
}


