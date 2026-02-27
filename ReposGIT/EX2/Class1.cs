using System;

class Program
{
    static void Main(string[] args)
    {
        CalcularValorD();
        Console.ReadKey();
    }

    static void CalcularValorD()
    {
        int A, B, C;
        double R, S, D;

        Console.Write("Digite o valor de A: ");
        A = int.Parse(Console.ReadLine());

        Console.Write("Digite o valor de B: ");
        B = int.Parse(Console.ReadLine());

        Console.Write("Digite o valor de C: ");
        C = int.Parse(Console.ReadLine());

        R = Math.Pow(A + B, 2);
        S = Math.Pow(B + C, 2);
        D = (R + S) / 2;

        Console.WriteLine("O valor de D é: " + D);
    }
}