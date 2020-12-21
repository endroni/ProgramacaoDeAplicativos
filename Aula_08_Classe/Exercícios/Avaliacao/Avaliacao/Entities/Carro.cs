using System;

namespace Avaliacao.Entities
{
    class Carro
    {
        public string Marca { get; set; }
        public string Modelo { get; set; }
        public int AnoFabricacao { get; set; }

        public Carro()
        {
        }

        public Carro(string marca, string modelo, int anoFabricacao)
        {
            Marca = marca;
            Modelo = modelo;
            AnoFabricacao = anoFabricacao;
        }

        public override string ToString()
        {
            return Modelo + " ano " + AnoFabricacao;
        }

        public int CalculaIdade()
        {
            return DateTime.Now.Year - AnoFabricacao;
        }
    }
}

