using ProjetoPratico.ContentContext.Enums;

namespace ProjetoPratico.ContentContext 
{
    internal class Course : Content
    {
        public string Tag { get; set; } 
        public IList<Module> Modules { get; set; } = new IList<Module>(); // Sempre que trabalhar com uma Lista como sendo Propriedade de Objetos, inicie o Objeto.
        public int DurationInMinutes { get; set; }
        public EContentLevel Level { get; set; }
    }
}