namespace EntendendoLlinq_04
{
    public partial class LinqForm : Form
    {
        public LinqForm()
        {
            InitializeComponent();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            List<Produto> listaProdutos = new Produto().GetAll();

            // LinqFiltrar(listaProdutos);
            LinqFiltrarClassificar(listaProdutos);
        }

        // Filtrar
        private void LinqFiltrar (List<Produto> listaProdutos)
        {
            var listaProdutosFiltrada =
                from produto in listaProdutos
                where produto.Id < 15
                select produto;

            foreach (var produto in listaProdutosFiltrada)
            {
                MessageBox.Show($"ID {produto.Id} - {produto.Nome}");
            }
        }

        // Filtrar e Classificar 
        private void LinqFiltrarClassificar (List<Produto> listaProdutos)
        {
            var listaProdutosFiltradaClassificada =
                from produto in listaProdutos
                where produto.Id < 15
                orderby produto.Nome ascending
                select produto;

            foreach (var produto in listaProdutosFiltradaClassificada)
            {
                MessageBox.Show($"ID {produto.Id} - {produto.Nome}");
            }
        }
    }
}