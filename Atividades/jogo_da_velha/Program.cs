string[][] game = new string[3][];
game[0] = new string[] { "1", "2", "3" };
game[1] = new string[] { "4", "5", "6" };
game[2] = new string[] { "7", "8", "9" };

//apresentação do tabuleiro
for (int i = 0; i < game.Length; i++)
{
    for (int j = 0; j < game[i].Length; j++)
    {
        Console.Write("[");
        Console.Write($" {game[i][j]}");
        Console.Write(" ]");
    }
    Console.WriteLine();
}

//condição como false para vitoria (se true = jogo acaba)
bool victory = false;
while (!victory)
{
    Console.WriteLine("Selecione uma casa: ");
    string userImput = Console.ReadLine();

    for (int i = 0; i < game.Length; i++)
    {
        for (int j = 0; j < game[i].Length; j++)
        {
            if (game[i][j] == userImput)
            {
                game[i][j] = "X";
            }
            Console.Write("[");
            Console.Write($" {game[i][j]}");
            Console.Write(" ]");
        }
        Console.WriteLine();
    }

    for (int i = 0; i < 3; i++)
    {
        if (game[i][0] == "X" && game[i][1] == "X" && game[i][2] == "X")
        {
            Console.WriteLine("GG!");
            victory = true;
        }
        if (game[0][i] == "X" && game[1][i] == "X" && game[2][i] == "X")
        {
            Console.WriteLine("GG!");
            victory = true;
        }
    }
    if (game[0][0] == "X" && game[1][1] == "X" && game[2][2] == "X")
    {
        Console.WriteLine("GG!");
        victory = true;
    }
    if (game[0][2] == "X" && game[1][1] == "X" && game[2][0] == "X")
    {
        Console.WriteLine("GG!");
        victory = true;
    }
}
Console.ReadKey();