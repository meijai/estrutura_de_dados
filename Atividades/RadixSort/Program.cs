using System;

namespace RadixSort
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== RADIX SORT DEMONSTRAÇÃO ===\n");

            // Exemplo de array desordenado
            int[] numeros = { 170, 45, 75, 90, 802, 24, 2, 66 };

            Console.WriteLine("Array original:");
            RadixSort.PrintArray(numeros);

            // Chama o método de ordenação
            RadixSort.Sort(numeros);

            Console.WriteLine("\nArray ordenado com Radix Sort:");
            RadixSort.PrintArray(numeros);

            Console.WriteLine("\nPressione qualquer tecla para sair...");
            Console.ReadKey();
        }
    }
}
