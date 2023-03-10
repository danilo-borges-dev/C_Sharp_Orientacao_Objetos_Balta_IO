using System.Globalization;

namespace EntendendoLlinq_04
{
    public partial class Metodos : Form
    {
        public Metodos()
        {
            InitializeComponent();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            List<Produto> listaProdutos = new Produto().GetAll();

            // dataGridProdutos.DataSource = LinqSkip(listaProdutos, 3);
            dataGridProdutos.DataSource = LinqTake(listaProdutos, 1);
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

        // Single - Se achar mais de Um ou Nenhum Lance uma Exce??o
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
                    MessageBox.Show("ID n?o econtrado ou encontrado mais de um produto.");
                }
                else
                {
                    MessageBox.Show(ex.HResult + " - " + ex.Message);
                }
            }
        }

        // Single or Default 
        private void LinqSingleOrDefault(int id, List<Produto> listaProdutos)
        {
            try
            {
                var produto = listaProdutos.SingleOrDefault(p => p.Id >= id);

                if (produto != null)
                {
                    MessageBox.Show($"ID {produto.Id} - {produto.Nome}");
                }
                else
                {
                    MessageBox.Show($"Produto com ID {id} n?o econtrado.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.HResult + " - " + ex.Message);
            }            
        }

        // First - Se Achar 2 ou mais vai pegar o Primeiro, mas sen?o achar nenhum Lan?a uma Exce??o
        private void LinqFirst(int id, List<Produto> listaProdutos)
        {
            try
            {
                var produto = listaProdutos.First(p => p.Id == id);
                MessageBox.Show($"ID {produto.Id} - {produto.Nome}");
            }
            catch (Exception ex)
            {
                if(ex.HResult == -2146233079)
                {
                    MessageBox.Show("Produto n?o econtrado ou existem mais de um produto com mesmo ID.");
                }
                MessageBox.Show(ex.HResult + " - " + ex.Message);
            }
        }
    }
}