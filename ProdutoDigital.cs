class ProdutoDigital
{
    public string Nome { get; set; }
    public double Preco { get; set; }
    public InformacaoTecnica InfoTecnica { get; set; }

    public ProdutoDigital(string nome, double preco, InformacaoTecnica infoTecnica)
    {
        Nome = nome;
        Preco = preco;
        InfoTecnica = infoTecnica;
    }

    public void ExibirDetalhes()
    {
        Console.WriteLine($"\nProduto: {Nome}");
        Console.WriteLine($"Preço: R${Preco}");
        Console.WriteLine($"Tamanho: {InfoTecnica.TamanhoMB}MB");
        Console.WriteLine($"Compatível com: {InfoTecnica.SistemaOperacional}");
    }
}