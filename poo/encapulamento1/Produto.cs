using System.Globalization;

namespace encapulamento1
{
    public class Produto
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

        public string GetNome()
        {
            return _nome;
        }

        public void SetNome(string nome)
        {
            if (nome != null && nome.Length > 1)
            {
                _nome = nome;
            }
        }

        public double GetPreco()
        {
            return _preco;
        }

        public void SetPreco(double preco)
        {
            _preco = preco;
        }

        public double GetQuantidade()
        {
            return _quantidade;
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
            return "Produto: " + _nome +
                   " | Preço Unit.: R$" + _preco.ToString("F2", CultureInfo.InvariantCulture) +
                   " | Quantidade: " + _quantidade +
                   " | Valor Total: R$" + ValorEstoque().ToString("F2", CultureInfo.InvariantCulture);
        }

    }
}
