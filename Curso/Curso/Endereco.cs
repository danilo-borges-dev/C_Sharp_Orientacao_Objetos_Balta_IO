namespace Curso
{
    internal class Endereco
    {
        public string Logradouro { get; private set; }
        public Cidade Cidade { get; set; } = null;
    }
}
