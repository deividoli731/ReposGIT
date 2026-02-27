using System;

class Program
{
    static void Main(string[] args)
    {
        MaiorESomaParOuImpar();
        Console.ReadKey();
    }

    static void MaiorESomaParOuImpar()
    {
        int A, B, C;
        int maior;
        int soma;

        Console.Write("Digite o valor de A: ");
        A = Convert.ToInt32(Console.ReadLine());

        Console.Write("Digite o valor de B: ");
        B = Convert.ToInt32(Console.ReadLine());

        Console.Write("Digite o valor de C: ");
        C = Convert.ToInt32(Console.ReadLine());

        if (A > B && A > C)
        {
            maior = A;
        }
        else if (B > A && B > C)
        {
            maior = B;
        }
        else
        {
            maior = C;
        }

        Console.WriteLine("O maior valor é: " + maior);

        soma = A + B + C;
        Console.WriteLine("A soma é: " + soma);

        if (soma % 2 == 0)
        {
            Console.WriteLine("A soma é PAR.");
        }
        else
        {
            Console.WriteLine("A soma é ÍMPAR.");
        }
    }
}