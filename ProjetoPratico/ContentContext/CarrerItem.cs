namespace ProjetoPratico.ContentContext 
{
    internal class CarrerItem 
    {
        public int Ordem { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public Course Course { get; set; }
    }
}