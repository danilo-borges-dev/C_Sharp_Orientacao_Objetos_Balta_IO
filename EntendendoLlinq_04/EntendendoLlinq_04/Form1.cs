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
            // LinqFiltrarClassificar(listaProdutos);
            // LinqAgrupar(listaProdutos);
            LinqSingle(21, listaProdutos);
        }

        // Filtrar
        private void LinqFiltrar(List<Produto> listaProdutos)
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
        private void LinqFiltrarClassificar(List<Produto> listaProdutos)
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

        // Agrupar
        private void LinqAgrupar(List<Produto> listaProdutos)
        {
            var listaProdutosAgrupada =
                from produtos in listaProdutos
                group produtos by produtos.Setor into setorGrupo
                orderby setorGrupo.Key ascending
                select setorGrupo;

            foreach (var grupo in listaProdutosAgrupada)
            {
                foreach (var produto in grupo)
                {
                    MessageBox.Show($"Grupo: {grupo.Key} - ID {produto.Id} - {produto.Nome}");
                }
            }
        }

        // Single - Se achar mais de Um ou Nenhum Lance uma Exceção
        private void LinqSingle(int id, List<Produto> listaProdutos)
        {
            try
            {
                var produto = listaProdutos.Single(p => p.Id == id);
                MessageBox.Show($"ID {produto.Id} - {produto.Nome}");
            }
            catch (Exception ex)
            {
                if (ex.HResult == -2146233079)
                {
                    MessageBox.Show("ID não econtrado ou encontrado mais de um produto.");
                }
                else
                {
                    MessageBox.Show(ex.HResult + " - " + ex.Message);
                }
            }
        }
    }
}