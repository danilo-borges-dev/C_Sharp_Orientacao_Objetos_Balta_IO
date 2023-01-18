namespace PlataformaBalta.ContentContex
{
    internal class Carrer : Content
    {
        public int Courses { get; private set; }
        public IList<CarrerItem> CarrerItems { get; private set; } = new List<CarrerItem>();
        public int TotalCourses => CarrerItems.Count;

        public Carrer (string title, string content) : base(title, content)
        {
            
        }
    }
}
