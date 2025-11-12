class Program
{
    static void Main()
    {
        string[] dados = new string[10]
        {
            "Jão", "Ana", "Cleber", "Ronaldinho", "Claudete",
            "Juarez", "Zuleide", "Eneias", "Jaspion", "Martim"
        };
        Console.WriteLine("Informe um nome para efetuar a busca: ");
        string pesquisa = Console.ReadLine();
        bool encontrado = true;

        for (int i = 0; i < dados.Length; i++)
        {
            if (dados[i] == pesquisa)
            {
                Console.WriteLine($"A sua busca foi encontrada no banco de dados na posição {i + 1} do vetor!");
                encontrado = false;
            }
        }
        if (encontrado == true)
        {
            Console.WriteLine("Nada encontrado no banco de dados!");
        }
        Console.ReadKey();
        Console.Clear();
    }
}