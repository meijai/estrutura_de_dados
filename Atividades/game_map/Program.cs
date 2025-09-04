using System;
using System.Text;

class Program
{
    static void Main()
    {
        TerrainEnum[,] map =
        {
            { TerrainEnum.SAND, TerrainEnum.SAND, TerrainEnum.SAND, TerrainEnum.SAND, TerrainEnum.GRASS, TerrainEnum.GRASS, TerrainEnum.GRASS, TerrainEnum.GRASS, TerrainEnum.GRASS, TerrainEnum.GRASS },
            { TerrainEnum.SAND, TerrainEnum.SAND, TerrainEnum.GRASS, TerrainEnum.GRASS, TerrainEnum.GRASS, TerrainEnum.GRASS, TerrainEnum.GRASS, TerrainEnum.GRASS, TerrainEnum.WALL,  TerrainEnum.WALL  },
            { TerrainEnum.WATER, TerrainEnum.WATER, TerrainEnum.SAND, TerrainEnum.SAND, TerrainEnum.GRASS, TerrainEnum.GRASS, TerrainEnum.WALL,  TerrainEnum.WALL,  TerrainEnum.WALL,  TerrainEnum.WALL  },
            { TerrainEnum.WATER, TerrainEnum.WATER, TerrainEnum.WATER, TerrainEnum.SAND, TerrainEnum.SAND, TerrainEnum.GRASS, TerrainEnum.GRASS, TerrainEnum.WALL,  TerrainEnum.GRASS, TerrainEnum.GRASS },
            { TerrainEnum.WATER, TerrainEnum.WATER, TerrainEnum.WATER, TerrainEnum.WATER, TerrainEnum.SAND, TerrainEnum.SAND, TerrainEnum.GRASS, TerrainEnum.GRASS, TerrainEnum.GRASS, TerrainEnum.GRASS },
            { TerrainEnum.WATER, TerrainEnum.WATER, TerrainEnum.WATER, TerrainEnum.WATER, TerrainEnum.WATER, TerrainEnum.SAND, TerrainEnum.SAND, TerrainEnum.GRASS, TerrainEnum.GRASS, TerrainEnum.GRASS },
            { TerrainEnum.WATER, TerrainEnum.WATER, TerrainEnum.WATER, TerrainEnum.WATER, TerrainEnum.WATER, TerrainEnum.WATER, TerrainEnum.SAND, TerrainEnum.SAND, TerrainEnum.GRASS, TerrainEnum.GRASS },
            { TerrainEnum.WATER, TerrainEnum.WATER, TerrainEnum.WATER, TerrainEnum.WATER, TerrainEnum.WATER, TerrainEnum.WATER, TerrainEnum.WATER, TerrainEnum.SAND, TerrainEnum.SAND, TerrainEnum.GRASS },
            { TerrainEnum.WATER, TerrainEnum.WATER, TerrainEnum.WATER, TerrainEnum.WATER, TerrainEnum.WATER, TerrainEnum.WATER, TerrainEnum.WATER, TerrainEnum.WATER, TerrainEnum.SAND, TerrainEnum.SAND },
            { TerrainEnum.WATER, TerrainEnum.WATER, TerrainEnum.WATER, TerrainEnum.WATER, TerrainEnum.WATER, TerrainEnum.WATER, TerrainEnum.WATER, TerrainEnum.WATER, TerrainEnum.WATER, TerrainEnum.SAND },
            { TerrainEnum.WATER, TerrainEnum.WATER, TerrainEnum.WATER, TerrainEnum.WATER, TerrainEnum.WATER, TerrainEnum.WATER, TerrainEnum.WATER, TerrainEnum.WALL,  TerrainEnum.WATER, TerrainEnum.WATER }
        };

        // Configura UTF-8 para mostrar os caracteres corretamente
        Console.OutputEncoding = Encoding.UTF8;

        for (int row = 0; row < map.GetLength(0); row++)
        {
            for (int col = 0; col < map.GetLength(1); col++)
            {
                Console.ForegroundColor = map[row, col].GetColor();
                Console.Write(map[row, col].GetChar() + " ");
            }
            Console.WriteLine();
        }

        // Resetar cor ao final
        Console.ForegroundColor = ConsoleColor.Gray;
    }
}
