using System;

namespace Developer.Parametros.Dinamicos
{
    class Program
    {
        static void Main(string[] args)
        {
            double soma = Calculator.Sum(1,2,3,4);
            Console.WriteLine($"Soma = {soma}");
        }
    }
}
