using ProjetoPratico.ContentContext.Enums;

namespace ProjetoPratico.ContentContext
{
    internal class Lecture 
    {
        public int Ordem { get; set; }
        public string Title { get; set; }
        public int DurationInMinutes { get; set; }
        public EContentLevel Level { get; set; }
    }
}