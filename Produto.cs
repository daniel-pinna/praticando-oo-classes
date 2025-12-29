class Produto
{
    public string Nome { get; set; }
    private int quantidadeEstoque;

    public Produto(string nome, int quantidadeInicial)
    {
        Nome = nome;
        quantidadeEstoque = quantidadeInicial;
    }

    public void Retirar(int quantidade)
    {
        if (quantidade <= quantidadeEstoque) {
            quantidadeEstoque -= quantidade;
            Console.WriteLine($"{quantidade} unidades de {Nome} retiradas do estoque.");
        } else {
            Console.WriteLine($"Estoque insuficiente para retirar {quantidade} unidades de {Nome}.");
        }
    }

    public void ExibirEstoque()
    {
        Console.WriteLine($"Estoque atual de {Nome}: {quantidadeEstoque} unidades.");
    }
}