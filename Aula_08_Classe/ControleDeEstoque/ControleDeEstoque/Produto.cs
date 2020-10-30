using System.Globalization;

namespace ControleDeEstoque
{
    class Produto
    {
        public string Nome;
        public double Preco;
        public int Quantidade;

        public Produto()
        {
            Quantidade = 20;
        }

        public Produto(string nome, double preco) : this ()
        {
            Nome = nome;
            Preco = preco;
        }

        public Produto (string nome, double preco, int quantidade) : this (nome, preco)
        {
            Quantidade = quantidade;
        }

        public double ValorTotalEmEstoque()
        {
            return Preco * Quantidade;
        }

        // Usamos aqui o void, porque esse método 
        // não irá retornar nada. 
        // Só vai atualizar

        public void AdicionarProdutos( int quantidade )
        {
            Quantidade += quantidade; 
        }

        public void RemoverProdutos (int quantidade)
        {
            Quantidade -= quantidade;
        }   

        public override string ToString()
        {
            return Nome +
                ", $ " +
                Preco.ToString("F2", CultureInfo.InvariantCulture) +
                ", " +
                Quantidade +
                " unidades, Total: $ " +
                ValorTotalEmEstoque().ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
