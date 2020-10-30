namespace FixacaoAluno
{
    class Aluno
    {
        public string Nome;
        public int telefone;
        public string Cidade;

        public Aluno() { }

        public Aluno(string nome, int telefone)
        {
            Nome = nome;
            this.telefone = telefone;
            Cidade = "Belo Horizonte";
        }

        public override string ToString()
        {
            return "Bem vindo " 
                + Nome + ", telefone " 
                + ", cidade " 
                + Cidade;
        }
    }
}
