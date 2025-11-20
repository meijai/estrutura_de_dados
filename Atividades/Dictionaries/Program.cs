// criando um dicionario vazio

Dictionary<string, int> dic0 = new Dictionary<string, int>();

// Criando um dicionario com valores

Dictionary<string, int> dic = new Dictionary<string, int>
{
    {"Chave 1", 100},
    {"Chave 2", 200},
};

//podemos adicionar informando diretamente a chave

dic["Chave 3"] = 300;
dic.Add("Chave 4", 400);

// para procurar

if(dic.ContainsKey("Chave 4"))
{
    Console.WriteLine($"Encontrado Chave 4, {dic["Chave 4"]}");
}

// percorrendo o dicionario

foreach (KeyValuePair<string, int> kv in dic)
{
    Console.WriteLine($"Chave: {kv.Key} - Valor: {kv.Value}");
}

Console.ReadKey();
Console.Clear();