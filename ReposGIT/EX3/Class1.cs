using System;

class Program
{
    static void Main(string[] args)
    {
        CalcularMediaPonderada();
        Console.ReadKey();
    }

    static void CalcularMediaPonderada()
    {
        double nota1, nota2, nota3, media;

        Console.Write("Digite a primeira nota: ");
        nota1 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Digite a segunda nota: ");
        nota2 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Digite a terceira nota: ");
        nota3 = Convert.ToDouble(Console.ReadLine());

        media = (nota1 * 2 + nota2 * 3 + nota3 * 5) / 10;

        Console.WriteLine("Média final: " + media);
    }
}