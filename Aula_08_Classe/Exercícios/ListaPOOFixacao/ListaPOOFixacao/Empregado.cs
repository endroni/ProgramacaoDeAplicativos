using System.Globalization;

namespace ListaPOOFixacao
{
    class Empregado
    {
        public int IdEmpregado { get; set; }
        public string NomeEmpregad { get; set; }
        public double Salario { get; set; }

        public Empregado()
        {
        }

        public Empregado(int idEmpregado, string nomeEmpregad, double salario)
        {
            IdEmpregado = idEmpregado;
            NomeEmpregad = nomeEmpregad;
            Salario = salario;
        }

        public void IncrementarSalario(double porcentagem)
        {
            Salario += Salario * porcentagem / 100;
        }

        public override string ToString()
        {
            return
                IdEmpregado +
                ", " +
                NomeEmpregad +
                ", " +
                Salario.ToString("F2", CultureInfo.InvariantCulture)
                ;
        }
    }
}
