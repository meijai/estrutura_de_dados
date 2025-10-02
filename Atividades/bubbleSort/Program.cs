using bubbleSort;

Console.WriteLine("Ordenação com Bubble Sort");

/*
int[] arrayNumbers = new int[] { -5, 9, 55, -48, -2, 0, -74, 485 };
*/

string[]arrayNames = new string[]
{
    "Ana",
    "Carlos",
    "Pedro",
    "Bruna",
    "Juliana",
    "Mariana",
    "João",
    "Gustavo"
};
Console.WriteLine("Valores desordenados:");


foreach (var X in arrayNames)
{
    Console.Write($" [{X}]");
}
Console.WriteLine();

Console.WriteLine("Valores ordenados:");

var arrayOrdered = BubbleSort.Sort<string>(arrayNames);
foreach (var X in arrayOrdered)
{
    Console.Write($" [{X}]");
}