class ContaBancaria
{
    public string NumeroConta { get; set; } 
    public double Saldo { get; set; }

    public ContaBancaria(string numeroConta, double saldoInicial)
    {
        NumeroConta = numeroConta;
        Saldo = saldoInicial;
    }
    
    public void Depositar(double valor)
    {
        Saldo += valor;
    }
}