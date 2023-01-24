namespace ProjetoPratico.ContentContext 
{
    internal class Carrer : Content
    {
        public IList<CarrerItem> Items { get; set; } = new IList<CarrerItem>();
        public int TotalCourses 
        { 
            get 
            {
                return Items.Count;
            }
        }
    }
}