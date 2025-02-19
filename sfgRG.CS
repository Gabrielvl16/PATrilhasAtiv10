using System;

class program
{
    static void Main()
    {
        int[,] numeros = new int[3, 3];

        for (int i = 0; i < 3; i++)
        {
            for (int j = 0; j < 3; j++)
            {
                Console.Write(numeros[i, j] + " ");
            }

            Console.WriteLine();
        }

        Console.WriteLine("Pressione qualquer tecla para sair . . .");
        Console.ReadKey();
    }
}
