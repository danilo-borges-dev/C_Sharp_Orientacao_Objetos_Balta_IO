namespace PlataformaBalta.ContentContex
{
    internal class CarrerItem
    {
        public int Order { get; private set; }
        public string Title { get; private set; }
        public string Description { get; private set; }
        public Course Course { get; private set; }
        public CarrerItem(int order, string title, string description, Course course)
        {
            Order = order;
            Title = title;
            Description = description;
            Course = course;
        }
    }
}
