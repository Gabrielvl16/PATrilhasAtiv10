using System;

class Program
{
    static void Main()
    {
        // Inicializando a matriz 10x10
        int[,] matriz = new int[10, 10];
        int somaDiagonalPrincipal = 0, somaDiagonalSecundaria = 0;
        
        // Preenchendo a matriz com valores inteiros
        Console.WriteLine("Digite os elementos da matriz 10x10:");

        for (int i = 0; i < 10; i++)
        {
            for (int j = 0; j < 10; j++)
            {
                Console.Write($"Elemento [{i},{j}]: ");
                matriz[i, j] = int.Parse(Console.ReadLine());
            }
        }

        // Exibindo a matriz
        Console.WriteLine("\nMatriz 10x10:");
        for (int i = 0; i < 10; i++)
        {
            for (int j = 0; j < 10; j++)
            {
                Console.Write(matriz[i, j] + "\t");
            }
            Console.WriteLine();
        }

        // Calculando a soma e a média da diagonal principal
        for (int i = 0; i < 10; i++)
        {
            somaDiagonalPrincipal += matriz[i, i];  // Elementos da diagonal principal
        }
        double mediaDiagonalPrincipal = somaDiagonalPrincipal / 10.0;

        // Calculando a soma e a média da diagonal secundária
        for (int i = 0; i < 10; i++)
        {
            somaDiagonalSecundaria += matriz[i, 9 - i];  // Elementos da diagonal secundária
        }
        double mediaDiagonalSecundaria = somaDiagonalSecundaria / 10.0;

        // Exibindo os resultados
        Console.WriteLine($"\nSoma da Diagonal Principal: {somaDiagonalPrincipal}");
        Console.WriteLine($"Média da Diagonal Principal: {mediaDiagonalPrincipal:F2}");

        Console.WriteLine($"\nSoma da Diagonal Secundária: {somaDiagonalSecundaria}");
        Console.WriteLine($"Média da Diagonal Secundária: {mediaDiagonalSecundaria:F2}");

        Console.WriteLine("Pressione qualquer tecla para sair...");
        Console.ReadKey();
    }
}
