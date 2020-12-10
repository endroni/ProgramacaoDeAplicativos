namespace Heranca.Entiites
{
    class Conta
    {
        public int Numero { get; set; }
        public string Titular { get; set; }
        public double Saldo { get; set; }

        public Conta()
        {
        }

        public Conta(int numero, string titular, double saldo)
        {
            Numero = numero;
            Titular = titular;
            Saldo = saldo;
        }

        public void Saque(double valor)
        {
            Saldo -= valor;
        }

        public void Deposito(double valor)
        {
            Saldo += valor;
        }
    }
}

