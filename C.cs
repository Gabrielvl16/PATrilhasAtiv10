using System;

class Program
{
    static void Main()
    {
        // Criando matrizes
        int[,] matrizUm = new int[4, 2];
        int[,] matrizDois = new int[4, 2];
        int[,] resultado = new int[4, 2];

        // Recebendo valores das matrizes
        for (int i = 0; i < 4; i++)
        {
            for (int j = 0; j < 2; j++)
            {
                Console.Write($"Digite um valor para a matriz 1 [{i},{j}]: ");
                matrizUm[i, j] = int.Parse(Console.ReadLine());

                Console.Write($"Digite um valor para a matriz 2 [{i},{j}]: ");
                matrizDois[i, j] = int.Parse(Console.ReadLine()); 
            }
        }

        // Somando matriz um é dois 
        for (int i = 0; i < 4; i++)
        {
            for (int j = 0; j < 2; j++)
            {
                resultado[i, j] = matrizUm[i, j] + matrizDois[i, j];
            }
        }

        // Exibindo resultado
        Console.WriteLine("Resultado da soma das matrizes: ");
        for (int i = 0; i < 4; i++)
        {
            for (int j = 0; j < 2; j++)
            {
                Console.Write(resultado[i, j] + " ");
            }
            Console.WriteLine();    
        }   
    }
}
