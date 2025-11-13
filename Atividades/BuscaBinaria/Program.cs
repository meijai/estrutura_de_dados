
int[] numeros = {2, 4, 6, 8, 10};
Console.WriteLine(BinarySearchIterative(numeros, 8)); // Saida: 4

string[] nomes = { "Ana", "Bruno", "Carlos", "Diana" };
Console.WriteLine(BinarySearchIterative(nomes, "Carlos")); //Saida: 3
double[] valores = {1.1, 2.2, 3.3, 4.4, 5.5 };
Console.WriteLine(BinarySearchIterative(valores, 7.7)); // Saida: Nill

//---------------

Console.WriteLine(BinarySearchRecursive(numeros, 6, 0, numeros.Length - 1)); // saida:3
Console.WriteLine(BinarySearchRecursive(nomes, "Carlos", 0, nomes.Length - 1)); // saida:
Console.WriteLine(BinarySearchRecursive(valores, 7.7, 0, valores.Length - 1)); //saida: Nill


static object BinarySearchIterative<T>(T[] inputArray, T key) where T : IComparable<T>
{
    int min = 0;
    int max = inputArray.Length - 1;

    while(min <= max)
    {
        int mid = (min + max) / 2;
        int comparison = key.CompareTo(inputArray[mid]);
        if (comparison == 0)
        {
            // retorna indice (1-based, como no seu codigo original)
            return mid + 1;
        }
        else if (comparison < 0)
        {
            max = mid - 1;
        }
        else
        {
            min = mid + 1;
        }
    }
    return "Nil";
}

static object BinarySearchRecursive<T>(T[] inputArray, T key, int min, int max) where T : IComparable<T>
{
    if (min > max)
    {
        return "Nil";
    }
    else
    {
        int mid = (min + max) / 2;
        int comparison = key.CompareTo(inputArray[mid]);
        if (comparison == 0)
        {
            // retorna indice (1-based, cini bi seu codigo original)
            return mid + 1;
        }
        else if (comparison < 0)
        {
            return BinarySearchRecursive(inputArray, key, min, mid - 1);
        }
        else
        {
            return BinarySearchRecursive(inputArray, key, mid +1, max);
        }
    }
}