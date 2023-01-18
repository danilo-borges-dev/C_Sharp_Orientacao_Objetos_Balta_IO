namespace EntendoLinq
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            //Produto produto = new();
            //var listaProdutos = produto.GetAll();
            List<Produto> listaProdutos = new Produto().GetAll();

            LinqFiltrar(listaProdutos);
        }
        private void LinqFiltrar(List<Produto> listaProdutos)
        {
            var listaProdutosFiltrada =
            from produto in listaProdutos
            where produto.Id < 2
            select produto;

            foreach (var item in listaProdutosFiltrada)
            {
                MessageBox.Show(item.Descricao);
            }
        }

    }
}