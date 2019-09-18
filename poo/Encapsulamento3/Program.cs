using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulamento3
{
    class Program
    {
        static void Main(string[] args)
        {
            Produto p = new Produto("TV", 500.00, 10);

            p.Nome = "TV 4K";
            p.SetPreco(750);
            p.AddQuantidade(20);


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
