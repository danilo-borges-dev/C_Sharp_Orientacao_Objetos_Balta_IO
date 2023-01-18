namespace EntendendoLinqPart_2
{
    internal class Produto
    {
        public int Id { get; private set; }
        public string Nome { get; private set; } = string.Empty;
        public string Descricao { get; private set; } = string.Empty;
        public decimal Unitario { get; private set; }
        public string Setor { get; private set; } = string.Empty;
        public Produto() { }
        public Produto(int id, string nome, string descricao, decimal unitario, string setor)
        {
            Id = id;
            Nome = nome;
            Descricao = descricao;
            Unitario = unitario;
            Setor = setor;
        }
        public List<Produto> GetAll()
        {
            List<Produto> listaProdutos = new List<Produto>();

            listaProdutos.Add(new Produto(1, "Macarrão", "Granulado de 1kg", 5.0M, "Alimentos"));
            listaProdutos.Add(new Produto(7, "Feijão", "Carioca de 1kg", 4.50M, "Alimentos"));
            listaProdutos.Add(new Produto(15, "Quiboa", "Liquida de 1 litro", 5.0M, "Limpeza"));
            listaProdutos.Add(new Produto(4, "Sabão de Barra", "12 barras de 2kg", 3.75M, "Limpeza"));
            listaProdutos.Add(new Produto(21, "Suco de Uva", "Suco para 2 Litros 30g", 2.50M, "Alimentos"));
            listaProdutos.Add(new Produto(9, "Detergente Líquido", "Frasco com 1 litro", 7.20M, "Limpeza"));

            return listaProdutos;
        }
    }
}
