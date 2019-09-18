using System.Globalization;

namespace Encapsulamento3
{
    class Produto
    {
        private string _nome;
        public double Preco { get; private set; }
        public int Quantidade { get; private set; }

        public Produto()
        {
            Quantidade = 0;
        }

        public Produto(string nome, double preco) : this()
        {
            _nome = nome;
            Preco = preco;
        }

        public Produto(string nome, double preco, int quantidade) : this(nome, preco)
        {
            Quantidade = quantidade;
        }

        public string Nome
        {
            get { return _nome; }
            set
            {
                if (value != null && value.Length > 1)
                {
                    _nome = value;
                }
            }

        }

        public void SetPreco(double preco)
        {
            Preco = preco;
        }

        public void AddQuantidade(int quantidade)
        {
            Quantidade += quantidade;
        }

        public void RemoverQuantidade(int quantidade)
        {
            Quantidade -= quantidade;
        }

        public double ValorEstoque()
        {
            return Preco * Quantidade;
        }

        public override string ToString()
        {
            return $"Produto: {_nome} | Preço Unit.: R$ {Preco.ToString("F2", CultureInfo.InvariantCulture)} " +
                $"| Quantidade: { Quantidade} | Valor Total: R$ {ValorEstoque().ToString("F2", CultureInfo.InvariantCulture)}";
        }
    }
}
