using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

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

        public Conta(int numero, string titular, decimal saldo) : this(numero, titular)
        {
            Saldo = saldo;
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
            return $"\nDados da Conta :\nConta: {Numero}, Titular: {Titular}, Saldo: R${Saldo.ToString("F2", CultureInfo.InvariantCulture)}";
        }



    }
}
