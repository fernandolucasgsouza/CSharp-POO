using System;
using System.Collections.Generic;

namespace Developer.Estoque
{
    public class Produto
    {
        List<ProdutoModel> ListaProduto = new List<ProdutoModel>();
        private int _Id;

        public Produto()
        {
            _Id = 0;
        }

        public void AdicionarProdutoEmEstoque()
        {
            Console.Write("informe NOME do produto: ");
            string nome = Console.ReadLine();
            Console.Write("informe PREÇO do produto: ");
            double preco = double.Parse(Console.ReadLine());
            Console.Write("informe QUANTIDADE do produto: ");
            int quantidade = int.Parse(Console.ReadLine());
            double total = preco * quantidade;
            
            ProdutoModel produto = new ProdutoModel(_Id, nome, preco, quantidade, total);

            var exists = ListaProduto.Exists(p => p.Nome.ToLower() == produto.Nome.ToLower());

            if (exists)
            {
                UpdateProduto(produto);
            }
            else
            {
                _Id++;
                produto.Id = _Id;
                ListaProduto.Add(produto);
            }
            Console.WriteLine($"Inserido com sucesso\n");
            Estoque();
        }

        public void RemoverProdutoEmEstoque()
        {
            Console.Write("Informe o (Id) do item : ");
            int _id = int.Parse(Console.ReadLine());

            foreach (var item in ListaProduto)
            {
                if (item.Id == _id)
                {
                    ListaProduto.Remove(item);
                    Estoque();
                    return;
                }
            };
            Console.WriteLine("Não existe item com o ID informado");
        }

        public void UpdateProduto(ProdutoModel produto)
        {
            ListaProduto.ForEach(element =>
            {
                if (element.Nome.ToLower() == produto.Nome.ToLower())
                {
                    element.Quantidade += produto.Quantidade;
                    element.Total += produto.Total;
                    element.Preco = element.Total / element.Quantidade;
                }
            });
        }

        public double ValorTotalEmEstoque()
        {
            double soma = 0;
            ListaProduto.ForEach(item => { soma += item.Preco * item.Quantidade; });
            return soma;
        }

        public void Estoque()
        {
            Console.WriteLine($"ESTOQUE:");
            foreach (var item in ListaProduto)
            {
                Console.WriteLine("Id:{0} Produto:{1} Preço:{2} Quantidade:{3} Total: R${4}", item.Id, item.Nome, item.Preco, item.Quantidade, item.Total);
            }
            Console.WriteLine($"===== Valor em Estoque R${ ValorTotalEmEstoque().ToString("F2")} =====");
        }

        public void Opcao()
        {
            Console.Write("====================================\n" +
                "Selecione a opção desejada:\n" +
               "[1] ADICIONAR um produto no estoque \n" +
               "[2] REMOVER um produto do estoque\n" +
               "[3] VALOR TOTAL do estoque \n" +
               "[4] SAIR\n" +
               "OPCAO: ");

            int opcao = int.Parse(Console.ReadLine());
            switch (opcao)
            {
                case 1:
                    AdicionarProdutoEmEstoque();
                    Opcao();
                    break;
                case 2:
                    RemoverProdutoEmEstoque();
                    Opcao();
                    break;
                case 3:
                    Console.WriteLine($"Valor em Estoque R${ ValorTotalEmEstoque().ToString("F2")}");
                    Opcao();
                    break;
                case 4:
                    Console.ReadLine();
                    break;
                default:
                    Console.WriteLine("Opção Invalida, Tente novamente");
                    Opcao();
                    break;
            }

        }

    }
}
