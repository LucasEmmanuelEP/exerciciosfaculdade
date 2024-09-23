public class Retangulo
{
    public double Largura { get; set; }
    public double Altura { get; set; }

    public double CalcularArea()
    {
        return Largura * Altura;
    }

    public double CalcularPerimetro()
    {
        return 2 * (Largura + Altura);
    }
}
