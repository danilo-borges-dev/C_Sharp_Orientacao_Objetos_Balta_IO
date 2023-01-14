namespace Curso
{
    internal class Client : IEquatable<Client>
    {
        public int Id { get; private set; }
        public string Name { get; private set; }
        public int Age { get; private set; }
        public Client(int id, string name, int age)
        {
            Id = id;
            Name = name;
            Age = age;
        }
        public bool Equals(Client? other)
        {
            if (this.Id == other.Id && this.Name == other.Name && this.Age == other.Age)
            {
                return true;
            }
            return false;
        }
    }
}
