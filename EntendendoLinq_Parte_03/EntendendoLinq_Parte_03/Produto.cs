namespace EntendendoLinq_Parte_03
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
        public List<Produto> GetaAll ()
        {
            List<Produto> listaProdutos = new List<Produto>();

            listaProdutos.Add(new Produto(5, "Macarrão", "Granulado de 1kg", 3.75M, "Alimentos"));
            listaProdutos.Add(new Produto(8, "Farinha", "De Trigo 1kg", 6.90M, "Alimentos"));
            listaProdutos.Add(new Produto(2, "Sabão em Barra", "Unitário 250g", 4.20M, "Limpeza"));
            listaProdutos.Add(new Produto(1, "Quiboa", "Liquída de 2 litros", 7.30M, "Limpeza"));
            listaProdutos.Add(new Produto(11, "Feijão Carioca", "Saco com 1kg", 5.0M, "Alimentos"));
            listaProdutos.Add(new Produto(22, "Bolacha", "Pacote com 140g", 1.75M, "Alimentos"));

            return listaProdutos;
        }
    }
}
