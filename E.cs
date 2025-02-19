using System;

class Program
{
    static void Main()
    {
        // Criando matriz
        float[,] numerosDecimais = new float[2, 2];
        float[,] resultado = new float[2, 2];

        // Recebendo valor das matrizes 
        for (int i = 0; i < 2; i++)
        {
            for (int j = 0; j < 2; j++)
            {
                Console.Write($"Digite um valor decimal [{i}, {j}]:");
                numerosDecimais[i, j] = float.Parse(Console.ReadLine());
            }
        }

        // Calculando a media dos valores 
        for (int i = 0; i < 2; i++)
        {
            for (int j = 0; j < 2; j++)
            {
                resultado[i, j] = numerosDecimais[i, j] / 2;
            }
        }

        // Exibindo resultado
        Console.WriteLine("Resultado: ");
        for (int i = 0; i < 2; i++)
        {
            for (int j = 0; j < 2; j++)
            {
                Console.Write(resultado[i, j] + " ");
            }
            Console.WriteLine();
        }

        Console.WriteLine("Pressione qualquer tecla para sair...");
        Console.ReadKey();
    }
}
