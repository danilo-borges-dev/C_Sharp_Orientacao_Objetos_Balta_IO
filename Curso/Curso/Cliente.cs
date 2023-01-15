namespace Curso
{
    internal class Cliente
    {
        public int Id { get; private set; } 
        public string Nome { get; private set; }
        public int Idade { get; private set; }
        public Endereco Endereco { get; set; } = null;
    }
}
