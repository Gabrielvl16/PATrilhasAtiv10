using System;

class Program
{
    static void Main()
    {
        // Inicializando a matriz 10x10
        int[,] matriz = new int[10, 10];
        int somaTotal = 0;

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

        // Calculando a soma de todos os elementos da matriz
        for (int i = 0; i < 10; i++)
        {
            for (int j = 0; j < 10; j++)
            {
                somaTotal += matriz[i, j];  // Somando os elementos
            }
        }

        // Exibindo o resultado da soma
        Console.WriteLine($"\nA soma de todos os elementos da matriz é: {somaTotal}");

        Console.WriteLine("Pressione qualquer tecla para sair...");
        Console.ReadKey();
    }
}
