using System.Globalization;

namespace ListaPOO
{
    class Esportes
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public double Investimento { get; set; }

        public Esportes(int id, string nome, double investimento)
        {
            Id = id;
            Nome = nome;
            Investimento = investimento;
        }

        public override string ToString()
        {
            return "Id: "
                + Id +
                " : " +
                Nome
                + " R$ "
                + Investimento.ToString("F2", CultureInfo.InvariantCulture)
                ;
        }
    }
}
