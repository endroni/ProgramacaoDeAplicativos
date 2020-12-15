namespace MetodosSeladosClasses.Entities
{
    class ContaPoupanca : Conta
    {
        public double TaxaJuros { get; set; }

        public ContaPoupanca()
        {
        }

        public ContaPoupanca(int numero, string titular, double saldo, double taxaJuros)
            : base(numero, titular, saldo)
        {
            TaxaJuros = taxaJuros;
        }

        public void AtualizaSaldo()
        {
            Saldo += Saldo * TaxaJuros;
        }

        public override void Saque(double valor)
        {
            base.Saque(valor);
            Saldo -= 2.0;
        }
    }
}
