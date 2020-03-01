using System;
using System.Globalization;

namespace Developer.ContaBancaria
{
    class Program
    {
        static void Main(string[] args)
        {

            Conta conta;

            Console.Write("Entre com o número da conta: ");
            int numero_conta = int.Parse(Console.ReadLine());
            Console.Write("Entre com o titular da conta: ");
            string titular = Console.ReadLine();

            Console.Write("Haverá deposito inicial (s/n): ");
            char questao = char.Parse(Console.ReadLine().ToUpper());

            if (questao == 'S')
            {
                Console.Write("Entre com o valor de deposito inicial: ");
                decimal deposito1 = decimal.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                conta = new Conta(numero_conta, titular, deposito1);
            }
            else
            {
                conta = new Conta(numero_conta, titular);
            }
            Console.WriteLine(conta);

            Console.Write("Entre com o valor para depósito: ");
            decimal deposito2 = decimal.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            conta.Deposito(deposito2);
            Console.WriteLine(conta);

            Console.Write("Entre com o valor de saque: ");
            decimal valorSaque = decimal.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            conta.Saque(valorSaque);
            Console.WriteLine(conta);


        }
    }
}
