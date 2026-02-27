using System;

class Program
{
    static void Main(string[] args)
    {
        VerificarParOuImpar();
        Console.ReadKey();
    }

    static void VerificarParOuImpar()
    {
        int numero;

        Console.Write("Digite um número inteiro: ");
        numero = Convert.ToInt32(Console.ReadLine());

        if (numero % 2 == 0)
        {
            Console.WriteLine("O número é PAR.");
        }
        else
        {
            Console.WriteLine("O número é ÍMPAR.");
        }
    }
}
