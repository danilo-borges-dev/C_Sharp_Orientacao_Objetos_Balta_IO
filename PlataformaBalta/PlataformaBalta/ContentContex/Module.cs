namespace PlataformaBalta.ContentContex
{
    internal class Module : Base
    {
        public int Order { get; private set; }
        public string Title { get; private set; }
        public IList<Lecture> Lectures { get; set; }
        public Module() 
        {
            Lectures = new List<Lecture>();
        }
    }
}
