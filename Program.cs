using System;
using System.Collections.Generic;

namespace ExercicioMatriz
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("digite a quantidade da matriz");
            int n = int.Parse(Console.ReadLine());

            int[,] matriz = new int[n, n];

            for (int i = 0; i < n; i++)
            {
                string[] value = Console.ReadLine().Split(' ');

                for (int j = 0; j < n; j++)
                {
                    matriz[i, j] = int.Parse(value[j]);
                }
            }



            for (int i = 0; i < n; i++)
            {
                Console.Write(matriz[i, i] + " ");
            }
            Console.WriteLine();

            var numerosNegativos = new List<int>();
            int negativos = 0;
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (matriz[i, j] < 0)
                    {
                        numerosNegativos.Add(matriz[i, j]);
                        negativos++;
                    }
                }
            }
            Console.WriteLine($"A quantidade de numeros negativos é = {negativos}, os numeros são :");
        }
    }
}
