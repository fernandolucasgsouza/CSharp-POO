using System.Globalization;

namespace Encapsulamento2
{
    class Produto
    {
        private string _nome;
        private double _preco;
        private double _quantidade;

        public Produto()
        {
            _quantidade = 0;
        }

        public Produto(string nome, double preco) : this()
        {
            _nome = nome;
            _preco = preco;
        }

        public Produto(string nome, double preco, int quantidade) : this(nome, preco)
        {
            _quantidade = quantidade;
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
        
        public double Preco
        {
            get { return _preco; }
            set { _preco = value; }
        }

        public double Quantidade
        {
            get { return _quantidade; }
        }

        public void AddQuantidade(int quantidade)
        {
            _quantidade += quantidade;
        }

        public void RemoverQuantidade(int quantidade)
        {
            _quantidade -= quantidade;
        }

        public double ValorEstoque()
        {
            return _preco * _quantidade;
        }

        public override string ToString()
        {
            return $"Produto: {_nome} | Preço Unit.: R$ {_preco.ToString("F2", CultureInfo.InvariantCulture)} " +
                $"| Quantidade: { _quantidade} | Valor Total: R$ {ValorEstoque().ToString("F2", CultureInfo.InvariantCulture)}";
        }
    }
}
