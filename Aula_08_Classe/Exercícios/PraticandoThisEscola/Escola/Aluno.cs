using System;

namespace Escola
{
    class Aluno
    {
        public string Nome;
        public string Email;
        public string Cidade;
        public Boolean Status;

        public Aluno()
        {
            Status = true;
        }

        public Aluno (string nome, string email, string cidade) : this()
        {
            Nome = nome;
            Email = email;
            Cidade = cidade;
        }
    }
}
