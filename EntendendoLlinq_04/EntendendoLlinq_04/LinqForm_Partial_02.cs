namespace EntendendoLlinq_04
{
    public partial class Metodos
    {
        // Pula "x" elementos de uma lista
        private List<Produto> LinqSkip(List<Produto> listaProdutos, int qtdItens)
        {
            return (
                    from produto in listaProdutos
                    select produto
                ).Skip(qtdItens).ToList();
        }

        // Pega os "x" primeiros valores de uma lista
        private List<Produto> LinqTake(List<Produto> listaProdutos, int qtdItens)
        {
            List<Produto> lista = (
                    from produto in listaProdutos
                    select produto
                ).Take(qtdItens).ToList();
            return lista;
        }
    }
}
