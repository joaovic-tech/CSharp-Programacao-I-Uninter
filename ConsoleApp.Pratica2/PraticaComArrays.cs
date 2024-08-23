using System;
using System.Collections.Generic;

namespace ConsoleApp.Pratica2
{
    public class PraticaComArrays
    {
        public void Exercicio1()
        {
            // Declarando um vetor de inteiros com 100.000 posições e valores lineares
            int[] arrayIntLinear = new int[100000];
            for (int i = 0; i < arrayIntLinear.Length; i++)
            {
                arrayIntLinear[i] = i;
            }

            // Armazenando os valores do array linear em um HashSet para busca rápida
            HashSet<int> valoresArray = new HashSet<int>(arrayIntLinear);

            // Declarando uma matriz de inteiros 100x100 com valores inteiros randômicos de 1 a 300.000
            int[,] matriz = new int[100, 100];
            Random rand = new Random();
            for (int i = 0; i < 100; i++)
            {
                for (int k = 0; k < 100; k++)
                {
                    matriz[i, k] = rand.Next(1, 300000);
                }
            }

            // Percorrendo a matriz e contando quantas de suas "casas" contêm os números presentes no vetor
            int countMatch = 0;
            for (int i = 0; i < 100; i++)
            {
                for (int k = 0; k < 100; k++)
                {
                    int valorMatriz = matriz[i, k];
                    if (valoresArray.Contains(valorMatriz))
                    {
                        countMatch++;
                    }
                }
            }

            // Resultados
            Console.WriteLine($"Houveram {countMatch} coincidências entre os valores randômicos da matriz e do array linear!");
        }
    }
}
