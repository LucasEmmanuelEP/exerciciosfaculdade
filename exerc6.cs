public class Funcionario
{
    public string Nome { get; set; }
    public string Cargo { get; set; }
    public double Salario { get; set; }

    public Funcionario(string nome, string cargo, double salario = 1500.00)
    {
        Nome = nome;
        Cargo = cargo;
        Salario = salario;
    }
}
