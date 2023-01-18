namespace EntendendoLlinq_04
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

    }
}
