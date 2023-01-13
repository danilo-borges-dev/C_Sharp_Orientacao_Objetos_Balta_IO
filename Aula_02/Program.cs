var pessoa = new Pessoa("Danilo");
var pessoa2 = new Pessoa("Danilo");

System.Console.WriteLine(pessoa.Equals(pessoa2));

class Pessoa : IEquatable<Pessoa>
{
    public string Nome { get; set; }
    public Pessoa (string nome)
    {
        Nome = nome;
    }

    public bool Equals(Pessoa? other)
    {
        if(this.Nome == other.Nome){
            return true;
        }
        return false;
    }
}


