namespace EntendendoLinqPart_2
{
    public partial class LinqForm : Form
    {
        public LinqForm()
        {
            InitializeComponent();
        }
        private void LinqFiltrar(List<Produto> listaProdutos)
        {
            var listaProdutosFiltrada = 
                from produto 
                in listaProdutos 
                where produto.Id < 15 
                select produto;

            foreach (var item in listaProdutosFiltrada)
            {
                MessageBox.Show($"ID {item.Id} - {item.Nome}");
            }
        }

        private void okButton_Click(object sender, EventArgs e)
        {
            List<Produto> listaProduto = new Produto().GetAll();

            LinqFiltrar(listaProduto);
        }
    }
}