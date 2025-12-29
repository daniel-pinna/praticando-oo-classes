class Filme
{
    public string Titulo { get; }
    public int ClassificacaoEtaria { get; }

    public Filme(string titulo, int classificacaoEtaria)
    {
        Titulo = titulo;
        ClassificacaoEtaria = classificacaoEtaria;
    }

    public bool PodeAssistir(int idadeUsuario)
    {
        if (idadeUsuario >= ClassificacaoEtaria) {
            return true;
        } else {
            return false;
        }
    }

    public void ExibirResultado(int idadeUsuario)
    {
        if (PodeAssistir(idadeUsuario)) {
            Console.WriteLine("Você pode assistir ao filme " + Titulo + ".\n");
        } else {
            Console.WriteLine("Você não pode assistir ao filme " + Titulo + ".\n");
        }
    }

}