using insertionSort;


Console.WriteLine("Ordenação com Bubble Sort");

int[] arrayNumbers = new int[] { -5, 9, 55, -48, -2, 0, -74, 485 };
Console.WriteLine("Valores desordenados:");

foreach (var number in arrayNumbers)
{
    Console.Write($" [{number}]");
}
Console.WriteLine();

Console.WriteLine("Valores ordenados:");

var arrayOrdered = InsertionSort.Sort<int>(arrayNumbers);
foreach (var number in arrayOrdered)
{
    Console.Write($" [{number}]");
}