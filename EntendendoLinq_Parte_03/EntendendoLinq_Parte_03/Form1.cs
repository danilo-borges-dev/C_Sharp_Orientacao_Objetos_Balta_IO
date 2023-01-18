namespace EntendendoLinq_Parte_03
{
    public partial class LinqForm : Form
    {
        public LinqForm()
        {
            InitializeComponent();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            List<Produto> listaProdutos = new Produto().GetaAll();
            //LinqFiltrar(listaProdutos);
            // LinqFiltrarClassificar(listaProdutos);
            //LinqAgrupar(listaProdutos);
            //LinqSingle(21, listaProdutos);
            LinqSingleOrDefault(21, listaProdutos);
        }

        // Buscar Itens de Produto com ID menor que 15
        private void LinqFiltrar(List<Produto> listaProduto)
        {
            var listaDeProdutosFiltrada =
                from produto
                in listaProduto
                where produto.Id < 15
                select produto;

            foreach (var item in listaDeProdutosFiltrada)
            {
                MessageBox.Show($"ID {item.Id} - {item.Nome}");
            }
        }

        // Buscar itens e classficiar
        private void LinqFiltrarClassificar(List<Produto> listaProdutos)
        {
            var listaProdutosFiltrarClassificar =
                from produto
                in listaProdutos
                orderby produto.Nome ascending
                select produto;

            foreach (var item in listaProdutosFiltrarClassificar)
            {
                MessageBox.Show($"ID {item.Id} - {item.Nome}");
            }
        }

        // Agrupar
        private void LinqAgrupar(List<Produto> listaProdutos)
        {
            var listaProdutosAgrupados =
                from produto
                in listaProdutos
                group produto by produto.Setor
                into setorGrupo
                orderby setorGrupo.Key ascending
                select setorGrupo;

            foreach (var grupo in listaProdutosAgrupados)
            {
                var nomeGrupo = "Grupo: " + grupo.Key;
                //MessageBox.Show(nomeGrupo);
                foreach (var produto in grupo)
                {
                    MessageBox.Show(nomeGrupo + ": " + produto.Id + " " + produto.Descricao);
                }
            }
        }

        // Single - Se Achar Mais de Um ou Nenhum Lance uma Exceção
        private void LinqSingle(int id, List<Produto> listaProdutos)
        {
            try
            {
                var produto = listaProdutos.Single(p => p.Id == id);
                MessageBox.Show(produto.Id + " - " + produto.Nome);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.HResult + " - " + ex.Message);
            }
        }

        // Single or Default
        private void LinqSingleOrDefault(int id, List<Produto> listaProdutos)
        {
            var produto = listaProdutos.SingleOrDefault(p => p.Id == id);

            if (produto != null)
            {
                MessageBox.Show(produto.Id + " - " + produto.Descricao);
            }
            else
            {
                MessageBox.Show("Produto não econtrado");
            }
        }
    }
}