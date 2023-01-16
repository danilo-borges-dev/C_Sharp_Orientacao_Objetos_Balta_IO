using Curso;
using static System.Console;

Pedido pedido = new();

try
{
    WriteLine($"Nome da classe: {nameof(Pedido)}");
    WriteLine($"Nome do objeto: {nameof(pedido)}");
    WriteLine($"Chamada do Método: {pedido.PedidoMetodo(null)}");
    WriteLine($"Nome do método: {nameof(pedido.PedidoMetodo)}");
}
catch (ArgumentNullException ex)
{
    WriteLine(ex.Message);
}
catch (Exception ex)
{
    WriteLine(ex.Message);
}