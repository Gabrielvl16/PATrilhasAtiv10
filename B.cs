using System;

class Program
{
    static void Main()
    {
        int[,] matriz = new int[10, 10];

        // Preenchendo a matriz com valores de exemplo
        Console.WriteLine("Digite os elementos da matriz 10x10:");
        for (int i = 0; i < 10; i++)
        {
            for (int j = 0; j < 10; j++)
            {
                Console.Write("Elemento [{i},{j}]: ");
                matriz[i, j] = int.Parse(Console.ReadLine());
            }
        }

        // Imprimindo a diagonal principal
        Console.WriteLine("Elementos da diagonal principal:");
        for (int i = 0; i < 10; i++)
        {
            Console.WriteLine(matriz[i, i]);
        }
    }
}
