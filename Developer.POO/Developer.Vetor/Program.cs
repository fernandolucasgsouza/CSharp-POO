using Developer.Estoque;
using System;
using System.Globalization;

namespace Developer.Vetor
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Informe a quantidade de itens que desaja cadastrar: ");
            int n = int.Parse(Console.ReadLine());

            ProdutoModel[] vectorProd = new ProdutoModel[n];
            double soma = 0;

            for (int i = 0; i < n; i++)
            {
                Console.Write($"Nome do produto {i + 1} : ");
                string nome = Console.ReadLine();
                Console.Write($"Preco do produto {i + 1} : ");
                double preco = double.Parse(Console.ReadLine());
                Console.Write($"Quantidade do produto {i + 1} : ");
                int quantidade = int.Parse(Console.ReadLine());

                double total = quantidade * preco;
                vectorProd[i] = new ProdutoModel(nome, preco, quantidade, total);
                soma += total;
            }

            for (int i = 0; i < vectorProd.Length; i++)
            {
                Console.WriteLine($"Nome: {vectorProd[i].Nome}, Preco: {vectorProd[i].Preco}, Quantidade: {vectorProd[i].Quantidade}, Total: {vectorProd[i].Total}");
            }
            double media = soma / vectorProd.Length;

            Console.WriteLine($"Valor médio: {media.ToString("F2", CultureInfo.InvariantCulture)}");
        }
    }
}
