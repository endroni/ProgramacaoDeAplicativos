namespace SalarioFuncionarioReajuste
{
    class Empregado
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public double Salario { get; set; }

        public Empregado ()
        {

        }

        public Empregado (int id, string nome, double salario)
        {
            Id = id;
            Nome = nome;
            Salario = salario;
        }

        public void ReajusteSalario( double porcentagem)
        {
            Salario += porcentagem * Salario;
        }
    }
}
