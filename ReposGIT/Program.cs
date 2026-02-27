using System;
class Program
{
    static void Main()
    {
        double x1, y1, x2, y2, distancia;
        Console.Write("Digite o valor de x1: ");
        x1 = double.Parse(Console.ReadLine());
        Console.Write("Digite o valor de y1: ");
        y1 = double.Parse(Console.ReadLine());
        Console.Write("Digite o valor de x2: ");
        x2 = double.Parse(Console.ReadLine());
        Console.Write("Digite o valor de y2: ");
        y2 = double.Parse(Console.ReadLine());
        distancia = Math.Sqrt(
                    Math.Pow(x2 - x1, 2) +
                    Math.Pow(y2 - y1, 2)
                    );
        Console.WriteLine("A distância entre os pontos é: " + distancia);
        Console.ReadKey();
    }
}