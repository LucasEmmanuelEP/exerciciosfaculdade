public class ContaBancaria
{
    private double saldo;

    public string Titular { get; set; }

    public void Depositar(double valor)
    {
        saldo += valor;
    }

    public void Sacar(double valor)
    {
        if (valor <= saldo)
        {
            saldo -= valor;
        }
    }

    public double ExibirSaldo()
    {
        return saldo;
    }
}
