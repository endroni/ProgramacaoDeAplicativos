using System;

namespace Escola
{
    class Professor
    {
        public string Nome;
        public string Sobrenome;
        public int Telefone;
        public Boolean Oculos;

        public Professor()
        {
            Oculos = true;
        }

        public Professor(string nome, string sobrenome, int telefone) : this()
        {
            Nome = nome;
            Sobrenome = sobrenome;
            Telefone = telefone;
        }

        public string UsaOculos(Boolean oculos)
        {
            if (oculos == true)
            {
                return "4 olhos";
            } else
            {
                return "meio cego";
            }
        }

        public override string ToString()
        {
            return "O professor " 
                + Nome
                + " "
                + Sobrenome 
                + ", telefone " 
                + Telefone
                + " é "
                + UsaOculos(Oculos);
        }
    }
}
