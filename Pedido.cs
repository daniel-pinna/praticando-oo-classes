public class Pedido
{
    public string NumeroPedido { get; }
    public string NomeCliente { get; set; }
    public string Status { get; set;}

    public Pedido(string numeroPedido, string nomeCliente, string status)
    {
        NumeroPedido = numeroPedido;
        NomeCliente = nomeCliente;
        Status = status;
    }
    public void AtualizarStatus(string novoStatus)
    {
        if (!string.IsNullOrWhiteSpace(novoStatus) && novoStatus != Status && (novoStatus == "Enviado" || novoStatus == "Entregue" || novoStatus == "Pendente"))
        {
            Status = novoStatus;
        }
    }

    public void ExibirPedido()
    {
        Console.WriteLine($"\nPedido Número: {NumeroPedido} \nCliente: {NomeCliente} \nStatus: {Status}");
    }
}