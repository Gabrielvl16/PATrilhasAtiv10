using System;

class Program
{
    static void Main()
    {
        // Vetor com os nomes das lojas (8 lojas)
        string[] lojas = new string[8] { "Loja A", "Loja B", "Loja C", "Loja D", "Loja E", "Loja F", "Loja G", "Loja H" };

        // Vetor com os nomes dos produtos (4 produtos)
        string[] produtos = new string[4] { "Produto 1", "Produto 2", "Produto 3", "Produto 4" };

        // Matriz com os preços de todos os produtos em cada loja (8 lojas x 4 produtos)
        float[,] precos = new float[8, 4];

        // Preenchendo a matriz com preços (usando valores fictícios entre 10 e 150)
        Random rand = new Random();
        Console.WriteLine("Preenchendo a matriz de preços:");

        for (int i = 0; i < 8; i++)
        {
            for (int j = 0; j < 4; j++)
            {
                precos[i, j] = (float)(rand.NextDouble() * (150 - 10) + 10); // Preços entre 10 e 150
            }
        }

        // Exibindo os resultados onde o preço não ultrapasse R$ 120,00
        Console.WriteLine("\nRelação Produto - Loja - Preço (onde o preço não ultrapassa R$ 120,00):");
        
        for (int i = 0; i < 8; i++)  // Iterando sobre as lojas
        {
            for (int j = 0; j < 4; j++)  // Iterando sobre os produtos
            {
                if (precos[i, j] <= 120.00f)  // Verifica se o preço não ultrapassa R$ 120,00
                {
                    Console.WriteLine($"{produtos[j]} - {lojas[i]} - R$ {precos[i, j]:F2}");
                }
            }
        }

        Console.WriteLine("Pressione qualquer tecla para sair...");
        Console.ReadKey();
    }
}
