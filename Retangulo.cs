class Retangulo
{
    public int Altura { get; set; }
    public int Largura { get; set; }

    public void CalcularArea()
    {
        Console.WriteLine($"\nÁrea do Retângulo: {Altura * Largura}\n");
    }

}