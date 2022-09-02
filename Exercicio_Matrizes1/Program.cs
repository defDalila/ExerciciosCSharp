namespace Exemplo_Matrizes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Entre com a dimensão da matriz: ");
            Console.Write("Número de linhas: ");
            int m = int.Parse(Console.ReadLine());

            Console.Write("Número de Colunas: ");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine();

            int[,] matriz = new int[m, n];

            for (int i = 0; i < m; i++)
            {
                Console.Write($"Insira os valores da linha #{i + 1}: ");
                string[] linha = Console.ReadLine().Split(' ');

                for (int j = 0; j < n; j++)
                {
                    matriz[i, j] = int.Parse(linha[j]);
                }
            }
            Console.WriteLine();

            Console.Write("Insira o valor que procura na matriz: ");
            int valor = int.Parse(Console.ReadLine());

            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (matriz[i, j] == valor)
                    {
                        Console.WriteLine($"Posição: {i}, {j}");

                        if (j > 0)
                        {
                            Console.WriteLine($"Valor à Esquerda: {matriz[i, j - 1]}");
                        }

                        if (j < n - 1)
                        {
                            Console.WriteLine($"Valor à Direita: {matriz[i, j + 1]}");
                        }

                        if (i > 0)
                        {
                            Console.WriteLine($"Valor acima: {matriz[i - 1, j]}");
                        }

                        if (i < m - 1)
                        {
                            Console.WriteLine($"Valor abaixo: {matriz[i + 1, j]}");
                        }

                    }

                }
                Console.WriteLine();
            }
        }
    }
}