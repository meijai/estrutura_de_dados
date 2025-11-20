using System.Collections;

// a tabela hash é baseada no conceito de Par {chave - valor}
// a chave é a forma de se acessar o respectivo valor
// e por ser chave, deve ser unica.

Hashtable ht = new Hashtable ()
{
    { "Bruno Furlan", "123" },
    { "Bruno ", "456" }
};

// uma forma de adicionar um novo par

ht ["Mauricio Mattar"] = "789";

ht.Add("Cleber Nascimento", "675");

// verificar se existem pares chave-valor na tabela hash

if(ht.Count > 0)
{
    //Percorrer os pares armazenados na tabela hash
    foreach(DictionaryEntry entry in ht)
    {
        Console.WriteLine($"Chave: {entry.Key}\nValor: {entry.Value}");
    }
}
else
{
    Console.WriteLine("Tabela Hash vazia");
}

// Vimos que ao adicionar uma chave repetida a hashtable, o programa da crash e interrompe a execucao
// para evitar este comportamento, fazemos uso da clausula(sentenca) try {} catch {}

try
{
    ht.Add("Bruno Furlan", "555");
}

catch (ArgumentException ex2)
{
    Console.WriteLine("Não é possível adicionar chaves iguais.");
    // Console.WriteLine(ex2.Message);
    // throw ex2;
}

catch (Exception ex)
{
    Console.WriteLine("Erro Desconhecido");
}

finally
{
    Console.WriteLine("Agora vai! Segue em frente");
}

Console.Clear();

// agora o usuario vai informar

Console.WriteLine("Informe a chave: ");
string key = Console.ReadLine();

Console.WriteLine("Informe o valor da chave: ");
string value = Console.ReadLine();

try
{
    ht.Add(key, value);
    Console.WriteLine("Par chave-valor adicionado!");
}
catch
{
    Console.WriteLine("Ops! Chave já existente.");
}

// Agora faremos uma busca na tabela Hash

Console.WriteLine("O que procuras?!");
string search = Console.ReadLine();

if (ht.Contains(search))
{
    Console.WriteLine($"Encontrado! {search}, {ht[search]}");
}
else
{
    Console.WriteLine("Não existe!");
}
Console.ReadKey();
Console.Clear();