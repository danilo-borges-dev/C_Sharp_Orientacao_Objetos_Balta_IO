namespace PlataformaBalta.ContentContex
{
    internal class Lecture : Base
    {
        public int Ordem { get; private set; }
        public string Title { get; private set; }
        public int DurationInMinutes { get; private set; }
        public Lecture(int ordem, string title)
        {
            Ordem = ordem;
            Title = title;
        }
    }
}
