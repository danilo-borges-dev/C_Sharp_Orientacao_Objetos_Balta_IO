namespace Curso
{
    internal class Pedido
    {
        public Cliente Cliente { get; set; } = null;
        public double ValorTotal { get; private set; }

        public void PedidoMetodo(int valor)
        {
            if (valor != null)
            {
                ValorTotal = valor;
            }
            else
            {
                throw new NullReferenceException($"Erro: {nameof(ValorTotal)} nao pode ser nulo.");
            }
        }
    }
}
