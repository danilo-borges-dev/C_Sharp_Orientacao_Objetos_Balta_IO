namespace EntendendoLlinq_04
{
    public partial class Metodos
    {
        private List<Produto> LinqSkip(List<Produto> listaProdutos, int qtdItens)
        {
            return (
                    from produto in listaProdutos
                    select produto
                ).Skip(qtdItens).ToList();
        }
    }
}
