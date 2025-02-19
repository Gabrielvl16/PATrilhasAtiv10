using System;

class Program
{
    static void Main()
    {
        // Inicializando a matriz 4x4 com valores inteiros de escolha
        int[,] matriz = new int[4, 4]
        {
            { 12, 34, 57, 89 },
            { 45, 20, 32, 88 },
            { 67, 90, 21, 15 },
            { 28, 16, 54, 76 }
        };

        // Exibindo apenas os valores pares da matriz
        Console.WriteLine("Valores Pares na Matriz:");
        for (int i = 0; i < 4; i++)
        {
            for (int j = 0; j < 4; j++)
            {
                if (matriz[i, j] % 2 == 0) // Verifica se o número é par
                {
                    Console.Write(matriz[i, j] + "\t");
                }
            }
            Console.WriteLine(); // Quebra de linha após cada linha da matriz
        }

        Console.WriteLine("Pressione qualquer tecla para sair...");
        Console.ReadKey();
    }
}
