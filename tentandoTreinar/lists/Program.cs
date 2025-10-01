List<string> names = ["<name>", "Ana", "Felipe"];
foreach (var name in names)
{
    Console.WriteLine($"Hello {name.ToUpper()}.");
}
Console.WriteLine();
names.Add("Maria");
names.Add("Bill");
names.Add("Ana");
foreach (var name in names)
{
    Console.WriteLine($"Hello {name.ToUpper()}.");
}
Console.WriteLine($"My name is {names[0]}");
Console.WriteLine($"I've added {names[2]} and {names[3]} to this list.");
Console.WriteLine($"The list has {names.Count} people on it.");

var index = names.IndexOf("Felipe");
if (index == -1)
{
    Console.WriteLine($"when an item is not found, IndexOf returns {index}.");
}
else
{
    Console.WriteLine($"The name {names[index]} is at {index}");
}