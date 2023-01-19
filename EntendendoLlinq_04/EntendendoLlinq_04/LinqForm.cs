namespace EntendendoLlinq_04
{
    public partial class LinqForm
    {
        // Maior Valor
        private decimal LinqMax(List<Produto> listaProdutos)
        {
            decimal result = (
                    from produto in listaProdutos
                    select produto.Unitario
                ).Max();
            return result;
        }

        // Menor Valor
        private decimal LinqMin(List<Produto> listaProdutos)
        {
            decimal result = (
                    from produto in listaProdutos
                    //where produto.Setor == "Limpeza"
                    select produto.Unitario
                ).Min();
            return result;
        }
    }
}
