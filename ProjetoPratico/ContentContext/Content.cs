namespace ProjetoPratico.ContentContext 
{
    internal abstract class Content
    {
        public Guid Id { get; set; }
        public string Title { get; set; }
        public string Url { get; set; }

        public Content () 
        {
            // O ID pode ficar concentrado no Construtor da Classe Base, já que o ID é um para todos os demais objetos derivados
            Id = Guid.NewGuid();
        }
    }
}