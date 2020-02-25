namespace Developer.Estoque
{
    public class ProdutoModel
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public double Preco { get; set; }
        public int Quantidade { get; set; }
        public double Total { get; set; }

        public ProdutoModel(int id, string nome, double preco, int quantidade, double total)
        {
            Id = id;
            Nome = nome;
            Preco = preco;
            Quantidade = quantidade;
            Total = total;
        }
    }

}
