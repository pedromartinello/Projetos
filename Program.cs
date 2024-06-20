using System;

public class Program
{
    public static void Main()
    {
        Autor autor = new Autor("J. K. Rowling", "Reino Unido");
    
        Livro livro1 = new Livro("Harry Potter e a Pedra Filosofal", autor, 40.0);

        Console.WriteLine("Informações do Livro (antes do desconto):");
        livro1.MostrarInfo();

        livro1.AplicarDesconto(10.0);
        Console.WriteLine("\nInformações do Livro (após 10% de desconto):");
        livro1.MostrarInfo();

        livro1.AplicarDesconto(5);
        Console.WriteLine("\nInformações do Livro (após desconto adicional de R$ 5):");
        livro1.MostrarInfo();
    }
}
