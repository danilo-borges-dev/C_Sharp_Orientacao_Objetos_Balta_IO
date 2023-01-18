namespace PlataformaBalta.ContentContex
{
    internal class Article : Content
    {
        public string Content { get; private set; }
        public Article(string title, string url, string cotent) : base(title, url)
        {
            Content = cotent;
        }
    }
}
