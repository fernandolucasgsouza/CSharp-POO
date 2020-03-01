using System.Globalization;

namespace Developer.ContaBancaria
{
    public class Conta
    {
        public int Numero { get; private set; }
        public string Titular { get; set; }
        public decimal Saldo { get; private set; }

        public Conta(int numero, string titular)
        {
            Numero = numero;
            Titular = titular;
        }

        public Conta(int numero, string titular, decimal depositoInicial) : this(numero, titular)
        {
            Deposito(depositoInicial);
        }

        public void Deposito(decimal valor)
        {
            Saldo += valor;

        }

        public void Saque(decimal valor)
        {
            decimal taxa = 5;
            Saldo -= valor + taxa;
        }

        public override string ToString()
        {
            return $"Conta: {Numero}, Titular: {Titular}, Saldo: R${Saldo.ToString("F2", CultureInfo.InvariantCulture)}";
        }



    }
}
