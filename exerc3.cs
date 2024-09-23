public class Livro
{
    public string Titulo { get; set; }
    public string Autor { get; set; }
    public int AnoPublicacao { get; set; }
    public string Genero { get; set; }

    public void ExibirInformacoes()
    {
        Console.WriteLine($"Título: {Titulo}, Autor: {Autor}, Ano: {AnoPublicacao}, Gênero: {Genero}");
    }

    public bool EhFiccao()
    {
        return Genero.ToLower() == "ficção";
    }
}
