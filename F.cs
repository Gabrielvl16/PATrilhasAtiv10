using System;

class Program
{
    static void Main()
    {
        // Inicializando a matriz 3x3
        int[,] matriz = new int[3, 3];
        Random rand = new Random();

        // Preenchendo a matriz com valores aleatórios entre 1 e 100
        for (int i = 0; i < 3; i++)
        {
            for (int j = 0; j < 3; j++)
            {
                matriz[i, j] = rand.Next(1, 101); // Gera número aleatório entre 1 e 100
            }
        }

        // Exibindo a matriz
        Console.WriteLine("Matriz Gerada:");
        for (int i = 0; i < 3; i++)
        {
            for (int j = 0; j < 3; j++)
            {
                Console.Write(matriz[i, j] + "\t");
            }
            Console.WriteLine();
        }

        // Encontrando o maior valor na matriz
        int maiorValor = matriz[0, 0];
        for (int i = 0; i < 3; i++)
        {
            for (int j = 0; j < 3; j++)
            {
                if (matriz[i, j] > maiorValor)
                {
                    maiorValor = matriz[i, j];
                }
            }
        }

        // Exibindo o maior valor
        Console.WriteLine("\nO maior valor na matriz é: " + maiorValor);
        
        Console.WriteLine("Pressione qualquer tecla para sair...");
        Console.ReadKey();
    }
}
