namespace EntendoLinq
{
    internal class Produto
    {
        public int Id { get; private set; }
        public string Descricao { get; private set; } = string.Empty;
        public decimal Unitario { get; private set; }
        public string Setor { get; private set; } = string.Empty;
        public Produto() { }
        public Produto(int id, string descricao, decimal unitario, string setor)
        {
            Id = id;
            Descricao = descricao;
            Unitario = unitario;
            Setor = setor;
        }
        public List<Produto> GetAll ()
        {
            List<Produto> listaProdutos = new List<Produto>();
            listaProdutos.Add(new Produto(1, "Café em pó 250 gramas", 10.50M, "Alimentos"));
            listaProdutos.Add(new Produto(2, "Sabão em pó 500 gramas", 3.0M, "Limpeza"));
            listaProdutos.Add(new Produto(21, "Óleo de soja 1 litro", 7.23M, "Alimentos"));
            listaProdutos.Add(new Produto(8, "Café em pó 500 gramas", 4.0M, "Alimentos"));
            listaProdutos.Add(new Produto(9, "Feijão Carioca 1kg", 5.0M, "Alimentos"));
            listaProdutos.Add(new Produto(18, "Quiboa 1 litro", 11.50M, "Limpeza"));

            return listaProdutos;
        }
    }
}
