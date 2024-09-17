using System;
using System.Collections.Generic;

namespace ConsoleApp.Pratica2
{
    public class PraticaComArrays
    {
        public static void Exercicio1()
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

        public static void Exercicio2()
        {
            /* 
                Declarando vetor (array) de char e preenchendo-o com 100 valores
                aleatórios de A-Z
            */
            char[] randomChars = new char[100];
            Random rand = new Random();

            for (int i = 0; i < randomChars.Length; i++)
            {
                int randomNumber = rand.Next(0, 26); // Gera um número aleatório entre 0 e 25
                randomChars[i] = (char)('A' + randomNumber); // Converte para char 'A' a 'Z'
            }

            /*
                Solicitando ao usuário um valor de "início" e "fim"
                do intervalo de 0 a 99
            */
            int start, end;

            while (true)
            {
                Console.Write("Digite o valor de início (entre 0 e 99): ");
                string? startInput = Console.ReadLine();

                Console.Write("Digite o valor de fim (entre 0 e 99): ");
                string? endInput = Console.ReadLine();

                if (int.TryParse(startInput, out start) && int.TryParse(endInput, out end))
                {
                    if (start >= 0 && end < 100 && start <= end)
                    {
                        break; // Valores válidos, sai do loop
                    }
                }
                Console.WriteLine("Por favor, insira valores válidos entre 0 e 99.");
            }

            /*
                Recortando esses elementos para um novo array
            */
            int length = end - start + 1;
            char[] slicedArray = new char[length];
            Array.Copy(randomChars, start, slicedArray, 0, length);

            /*
                Convertendo esse novo array em uma string para o resultado
            */
            string result = new string(slicedArray);

            // Exibindo os valores
            Console.WriteLine();
            Console.WriteLine("Array original:");
            Console.WriteLine(new string(randomChars));

            Console.WriteLine();
            Console.WriteLine($"Intervalo selecionado [{start}, {end}]:");
            Console.WriteLine(result);
        }
    }
}
