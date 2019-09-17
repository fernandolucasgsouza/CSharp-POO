using System;

namespace Encapsulamento2
{
    class Program
    {
        static void Main(string[] args)
        {
            Produto p = new Produto("TV", 500.00, 10);

            p.Nome = "TV 4K";
            p.Preco = 752.25;
            p.AddQuantidade(15);

                       
            Console.WriteLine(p.Nome);
            Console.WriteLine(p.Preco);
            Console.WriteLine(p.Quantidade);
            Console.WriteLine(p.ValorEstoque());
            Console.WriteLine("---------------------------");
            Console.WriteLine(p);

            Console.ReadKey();
        }
    }
}
