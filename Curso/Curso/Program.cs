using Curso;
using static System.Console;

Pedido novoPedido = new();

Cliente cliente = new Cliente();
Endereco endereco = new Endereco();
Cidade cidade = new Cidade();

novoPedido.Cliente = cliente;
//cliente.Endereco = endereco;
endereco.Cidade = cidade;

//if (novoPedido.Cliente?.Endereco?.Cidade != null)
//{
//    // faça alguma coisa
//    Write("Não é Nullo. Faça alguma coisa.");
//}
//else
//{
//    Write("Lança uma exceção.");
//}

WriteLine($"Nome da Classe/Objeto: {nameof(novoPedido.PedidoMetodo)}");  // Nome do Método.
WriteLine($"Nome da Classe/Objeto: {nameof(Pedido.PedidoMetodo)}");  // Nome do Método acesado diretamente pela Notação de Classe.
WriteLine($"Nome da Proprieade: {nameof(novoPedido.Cliente)}");  // Nome da Prprieadade do Objeto "novoPedido".
