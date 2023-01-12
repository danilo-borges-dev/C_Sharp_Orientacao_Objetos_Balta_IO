using Pyament;

public class Contrato {
    public string Nome { get; private set; }  
    public Contrato Required() {
        return this;
    }
    public void Nome (string nome) {
        Nome = nome;
    }
}