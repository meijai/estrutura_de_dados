using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        Dictionary<string, string> dict = new Dictionary<string, string>();
        Console.Clear();
        while (true)
        {
            Console.WriteLine("\n1 - Cadastrar");
            Console.WriteLine("2 - Buscar por rastreio");
            Console.WriteLine("3 - Buscar por barras");
            Console.WriteLine("0 - Sair");
            Console.Write("Opção: ");

            int opc = int.Parse(Console.ReadLine());

            if (opc == 0)break;

            if (opc == 1)
            {
                Console.Write("Rastreio: ");
                string r = Console.ReadLine();

                Console.Write("Barras: ");
                string b = Console.ReadLine();

                if (!dict.ContainsKey(r))
                {
                    dict[r] = b;
                    Console.WriteLine("Cadastrado.");
                }
                else
                {
                    Console.WriteLine("Rastreio já existe.");
                }
                Console.ReadKey();
                Console.Clear();
            }
            else if (opc == 2)
            {
                Console.Write("Rastreio: ");
                string r = Console.ReadLine();

                if (dict.ContainsKey(r))
                    Console.WriteLine($"Barras: {dict[r]}");
                else
                    Console.WriteLine("Não encontrado.");
                    Console.ReadKey();
                    Console.Clear();
            }
            else if (opc == 3)
            {
                Console.Write("Barras: ");
                string b = Console.ReadLine();

                bool achou = false;
                foreach (var item in dict)
                {
                    if (item.Value == b)
                    {
                        Console.WriteLine($"Rastreio: {item.Key}");
                        achou = true;
                    }
                }

                if (!achou) Console.WriteLine("Não encontrado.");
                Console.ReadKey();
                Console.Clear();
            }
            else
            {
                Console.WriteLine("Inválido.");
                Console.ReadKey();
                Console.Clear();
            }
        }
    }
}
