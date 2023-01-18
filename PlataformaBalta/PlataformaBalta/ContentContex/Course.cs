using PlataformaBalta.ContentContex.Enums;

namespace PlataformaBalta.ContentContex
{
    internal class Course : Content
    {
        public Course(string title, string content) : base(title, content)
        {
        }

        public string Tag { get; private set; }
        public IList<Module> Modules { get; private set; } = new List<Module>();
        public int DurationInMinutes { get; private set; }
        public EContentLevel Level { get; private set; }
    }
}
