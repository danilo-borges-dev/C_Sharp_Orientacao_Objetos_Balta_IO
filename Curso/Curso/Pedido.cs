namespace Curso
{
    internal class Pedido
    {
        public Cliente Cliente { get; set; } = null;
        public double ValorTotal { get; private set; }

        public double PedidoMetodo(int? valorPedido)
        {
            if (valorPedido == null)
            {
                throw new ArgumentNullException($"Erro: O Valor de {nameof(ValorTotal)} não pode ser nulo.");
            }
            return ValorTotal += (int)valorPedido;
        }
    }
}
