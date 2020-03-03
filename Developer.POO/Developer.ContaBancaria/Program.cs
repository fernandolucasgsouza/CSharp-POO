using System;
using System.Globalization;

namespace Developer.Conta.Bancaria
{
    class Program
    {
        static void Main(string[] args)
        {

            Conta conta;
            string[] message = new string[] { "\nDados da conta:\n", "\nDados da conta atualizados:\n" };

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
                Console.WriteLine($"{message[0]}{conta}");
            }
            else
            {
                conta = new Conta(numero_conta, titular);
                Console.WriteLine($"{message[1]}{conta}");
            }

            Console.Write("Entre com o valor para depósito: ");
            decimal deposito2 = decimal.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            conta.Deposito(deposito2);
            Console.WriteLine($"{message[1]}{conta}");

            Console.Write("Entre com o valor de saque: ");
            decimal valorSaque = decimal.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            conta.Saque(valorSaque);
            Console.WriteLine($"{message[1]}{conta}");

        }
    }
}
