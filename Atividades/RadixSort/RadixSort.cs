using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RadixSort
{
    public class RadixSort
    {
        // Função auxiliar: Counting Sort com base em um dígito específico (exp)
        private static void CountingSort(int[] arr, int exp)
        {
            int n = arr.Length;
            int[] output = new int[n]; // Array de saída
            int[] count = new int[10]; // Contador para os dígitos (0 a 9)

            // Conta as ocorrências de cada dígito
            for (int i = 0; i < n; i++)
            {
                int index = (arr[i] / exp) % 10;
                count[index]++;
            }

            // Atualiza o count[i] para conter a posição real do dígito no output[]
            for (int i = 1; i < 10; i++)
                count[i] += count[i - 1];

            // Constrói o array de saída (mantendo estabilidade)
            for (int i = n - 1; i >= 0; i--)
            {
                int index = (arr[i] / exp) % 10;
                output[count[index] - 1] = arr[i];
                count[index]--;
            }

            // Copia o array de saída de volta para o original
            for (int i = 0; i < n; i++)
                arr[i] = output[i];
        }

        // Método principal do Radix Sort
        public static void Sort(int[] arr)
        {
            if (arr == null || arr.Length == 0)
                return;

            // Encontra o maior número para saber o número de dígitos
            int max = arr.Max();

            // Aplica o Counting Sort para cada dígito (1, 10, 100, ...)
            for (int exp = 1; max / exp > 0; exp *= 10)
                CountingSort(arr, exp);
        }

        // Método auxiliar para exibir o array no console
        public static void PrintArray(int[] arr)
        {
            Console.WriteLine(string.Join(" ", arr));
        }
    }
}
