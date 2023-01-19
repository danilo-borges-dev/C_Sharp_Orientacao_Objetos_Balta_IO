namespace EntendendoLlinq_04
{
    internal class Produto
    {
        public int Id { get; private set; } = new int();
        public string Nome { get; private set; } = string.Empty;
        public string Descricao { get; private set; } = string.Empty;
        public decimal Unitario { get; private set; } = new decimal();
        public string Setor { get; private set; } = string.Empty;
        public int Quantidade { get; private set; } = new int();
        public Produto() { }
        public Produto(int id, string nome, string descricao, decimal unitario, string setor, int quantidade)
        {
            Id = id;
            Nome = nome;
            Descricao = descricao;
            Unitario = unitario;
            Setor = setor;
            Quantidade = quantidade;
        }
        public List<Produto> GetAll ()
        {
            List<Produto> listaProdutos = new List<Produto>();

            listaProdutos.Add(new Produto(12, "Arroz", "Saco com 5kg Tipo 1", 5.80M, "Alimentação", 35));
            listaProdutos.Add(new Produto(5, "Feijão", "Saco com 1kg", 4.25M, "Alimentação", 60));
            listaProdutos.Add(new Produto(7, "Sabão de Coco", "Pacote com 12 Unidades", 8.0M, "Limpeza", 20));
            listaProdutos.Add(new Produto(15, "Suco de Limão", "Procte com 30g", 0.30M, "Alimentação", 120));
            listaProdutos.Add(new Produto(22, "Quiboa", "Fardo com 12 Litros", 110.45M, "Limpeza", 7));
            listaProdutos.Add(new Produto(9, "Doce de Leite", "Pote com 300g", 7.60M, "Alimentação", 13));

            return listaProdutos;
        }
    }
}
