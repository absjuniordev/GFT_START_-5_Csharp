using System;

namespace Questao_01
{
    class Program
    {
        static void Main(string[] args)
        {
            //Capt
            System.Console.Write("Digite a quantidade de linhas: ");
            int M = int.Parse(Console.ReadLine());
            System.Console.Write("Digite a quantidade de colunas: ");
            int N = int.Parse(Console.ReadLine());

            int[,] matriz = new int[M, N];

            System.Console.WriteLine($"Digite {N} numeros com espaços entre eles e ao final pressione [enter]:");

            for (int i = 0; i < M; i++)
            {
                string[] values = Console.ReadLine().Split(' ');

                for (int j = 0; j < N; j++)
                {
                    matriz[i, j] = int.Parse(values[j]);
                }
            }

          
            for (int i = 0; i < M; i++)
            {
                for (int j = 0; j < N; j++)
                {
                    System.Console.WriteLine($"Posição [{i}][{j}] = {matriz[i, j]}");
                    if (j > 0)
                    {
                        Console.WriteLine("Esquerda: " + matriz[i, j - 1]);
                    }
                    if (j < N - 1)
                    {
                        Console.WriteLine("Direita: " + matriz[i, j + 1]);
                    }
                    if (i > 0)
                    {
                        Console.WriteLine("Acima: " + matriz[i - 1, j]);
                    }

                    if (i < M - 1)
                    {
                        Console.WriteLine("Abaixo: " + matriz[i + 1, j]);
                    }

                }
            }
            Console.ReadKey();
        }
    }
}