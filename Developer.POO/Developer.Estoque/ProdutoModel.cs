namespace Developer.Estoque
{
    public class ProdutoModel
    {
        public int Id { get; set; }
        private string _nome { get; set; }
        public double Preco { get; set; }
        public int Quantidade { get; set; }
        public double Total { get; set; }

        public ProdutoModel()
        {

        }

        public ProdutoModel(string nome, double preco, int quantidade, double total)
        {
            Nome = nome;
            Preco = preco;
            Quantidade = quantidade;
            Total = total;
        }

        public ProdutoModel(int id, string nome, double preco, int quantidade, double total) : this(nome, preco, quantidade, total)
        {
            Id = id;

        }

        public string Nome
        {
            get
            {
                return _nome;
            }
            set
            {
                if (value != null) _nome = value;
            }
        }

    }

}
