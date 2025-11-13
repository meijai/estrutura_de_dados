int [] numeros = { 10, 20, 180, 30, 60, 50, 110, 100, 70 };
int keyInt = 180;
SentinelSearch(numeros, numeros.Length, keyInt);

string[] nomes = { "Ana", "Bruno", "Carlos", "Diana"};
string keyString = "Carlos";
SentinelSearch(nomes, nomes.Length, keyString);

static void SentinelSearch<T>(T[] arr, int n, T key)
{
    //Guardar o ultimo elemento
    T last = arr[n - 1];

    //Coloca o elemento a ser buscado na iultima posicao
    arr[n - 1] = key;
    int i = 0;

    //Busca ate encontrar o valor linha 73
    while (!EqualityComparer<T>.Default.Equals(arr[i], key))
        i++;

    //Restaura o ultimo elemento original
    arr[n - 1] = last;

    //Verifica se encontrou dentro da faixa valida
    if(i < n -1 || EqualityComparer<T>.Default.Equals(arr[i], key))
        Console.WriteLine($"{key} está presente no indice {i}");
    else
        Console.WriteLine($"Elemento nao encontrado");
}
