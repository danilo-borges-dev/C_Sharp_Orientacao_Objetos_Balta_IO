namespace ProjetoPratico.ContentContext 
{
    internal class Module
    {
        public int Order { get; set; }
        public string Title { get; set; }
        public IList<Lecture> Lectures { get; set; } = new IList<Lecture>();
    }
}