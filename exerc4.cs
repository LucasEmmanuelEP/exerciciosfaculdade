public class Aluno
{
    public string Nome { get; set; }
    public string Matricula { get; set; }
    private double[] notas;

    public Aluno(double[] notas)
    {
        this.notas = notas;
    }

    public double CalcularMedia()
    {
        double soma = 0;
        foreach (var nota in notas)
        {
            soma += nota;
        }
        return soma / notas.Length;
    }
}
