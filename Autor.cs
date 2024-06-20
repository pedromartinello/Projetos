using System;

public class Autor
{
    public string Nome;
    public string Nacionalidade;
    public Autor(string nome, string nacionalidade)
    {
        Nome = nome;
        Nacionalidade = nacionalidade;
    }
    public void MostrarInfo()
    {
        Console.WriteLine("Autor: " + Nome);
        Console.WriteLine("Nacionalidade: " + Nacionalidade);
    }
}