class Consulta
{
    public string NomePaciente { get; set; }
    public string NomeMedico { get; set; }
    public DateTime DataConsulta { get; set; }
    private bool isChanged = false;

    public Consulta(string nomePaciente, string nomeMedico, DateTime dataConsulta)
    {
        NomePaciente = nomePaciente;
        NomeMedico = nomeMedico;
        DataConsulta = dataConsulta;
    }

    public void Reagendar(DateTime novaData)
    {
        DataConsulta = novaData;
        isChanged = true;
    }

    public void ExibirResumo()
    {
        Console.WriteLine($"\nConsulta marcada com o(a) médico(a) {NomeMedico} para o(a) paciente: {NomePaciente}.");
        if (isChanged)
        {
            Console.WriteLine($"Data: {DataConsulta.ToString("dd/MM/yyyy")}");
        } else {
            Console.WriteLine($"Nova data: {DataConsulta.ToString("dd/MM/yyyy")}");
        }
    }
}