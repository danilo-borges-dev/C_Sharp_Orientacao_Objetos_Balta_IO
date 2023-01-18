namespace PlataformaBalta.ContentContex
{
    internal abstract class Content : Base
    {
        
        public string Title { get; private set; }
        public string Url { get; private set; }
        public Content(string title, string content)
        {
            Title = title;
        }
    }
}
