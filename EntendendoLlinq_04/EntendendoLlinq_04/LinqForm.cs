namespace EntendendoLlinq_04
{
    public partial class Metodos
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
                    where produto.Setor == "Limpeza"
                    select produto.Unitario
                ).Min();
            return result;
        }

        // Contar
        private int LinqCount(List<Produto> listaProdutos)
        {
            int result = (
                    from produto in listaProdutos
                    where produto.Setor == "Alimentação"
                    select produto
                ).Count();
            return result;
        }
    }

}
