using System;
using System.Collections.Generic;

public class Livro
{
    public string Titulo { get; set; }
    public string Autor { get; set; }
    public int AnoPublicacao { get; set; }
    public int NumeroPaginas { get; set; }
    public bool Disponivel { get; set; } = true;

    public void Emprestar()
    {
        Disponivel = false;
    }

    public void Devolver()
    {
        Disponivel = true;
    }

    public void ExibirInformacoes()
    {
        Console.WriteLine($"Título: {Titulo}, Autor: {Autor}, Ano: {AnoPublicacao}, Páginas: {NumeroPaginas}, Status: {(Disponivel ? "Disponível" : "Emprestado")}");
    }
}

public class Cliente
{
    public string Nome { get; set; }
    public int NumeroIdentificacao { get; set; }
    public List<Livro> LivrosEmprestados { get; set; } = new List<Livro>();

    public void EmprestarLivro(Livro livro)
    {
        LivrosEmprestados.Add(livro);
        livro.Emprestar();
    }

    public void DevolverLivro(Livro livro)
    {
        LivrosEmprestados.Remove(livro);
        livro.Devolver();
    }

    public void ExibirInformacoes()
    {
        Console.WriteLine($"Nome: {Nome}, ID: {NumeroIdentificacao}");
        Console.WriteLine("Livros Emprestados:");
        foreach (var livro in LivrosEmprestados)
        {
            Console.WriteLine($"- {livro.Titulo}");
        }
    }
}

public class Biblioteca
{
    public List<Livro> Livros { get; set; } = new List<Livro>();
    public List<Cliente> Clientes { get; set; } = new List<Cliente>();

    public void AdicionarLivro(Livro livro)
    {
        Livros.Add(livro);
    }

    public void RemoverLivro(Livro livro)
    {
        Livros.Remove(livro);
    }

    public void RegistrarCliente(Cliente cliente)
    {
        Clientes.Add(cliente);
    }

    public void RemoverCliente(Cliente cliente)
    {
        Clientes.Remove(cliente);
    }

    public void ExibirLivrosDisponiveis()
    {
        Console.WriteLine("Livros Disponíveis:");
        foreach (var livro in Livros)
        {
            if (livro.Disponivel)
            {
                livro.ExibirInformacoes();
            }
        }
    }

    public void ExibirClientes()
    {
        Console.WriteLine("Clientes Registrados:");
        foreach (var cliente in Clientes)
        {
            cliente.ExibirInformacoes();
        }
    }
}

public class Program
{
    public static void Main()
    {
        Biblioteca biblioteca = new Biblioteca();

        // Exemplo de uso:
        Livro livro1 = new Livro { Titulo = "1984", Autor = "George Orwell", AnoPublicacao = 1949, NumeroPaginas = 328 };
        Cliente cliente1 = new Cliente { Nome = "Alice", NumeroIdentificacao = 101 };

        biblioteca.AdicionarLivro(livro1);
        biblioteca.RegistrarCliente(cliente1);

        biblioteca.ExibirLivrosDisponiveis();
        cliente1.EmprestarLivro(livro1);
        biblioteca.ExibirLivrosDisponiveis();

        cliente1.ExibirInformacoes();
        cliente1.DevolverLivro(livro1);
        biblioteca.ExibirLivrosDisponiveis();
    }
}
