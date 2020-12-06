using System.Globalization;

namespace ListaPOOFixacao
{
    class Bebida
    {
        public int IdBebida { get; set; }
        public string NomeBebida { get; set; }
        public double ValorBebida { get; set; }

        public Bebida(int id, string nome, double valor)
        {
            IdBebida = id;
            NomeBebida = nome;
            ValorBebida = valor;
        }

        public override string ToString()
        {
            return "Id: " + IdBebida
                + " , " + NomeBebida
                + " R$ " + ValorBebida.ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
