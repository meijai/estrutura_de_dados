using System;
using System.Collections.Generic;

Console.WriteLine("Informe uma palavra para verificar se ela é um palíndromo:");
string word = Console.ReadLine();
Stack<char> chars = new Stack<char>(); //declarando u Stack do tipo char nomeado de word

foreach (var letra in word) // percorre letra por letra da variavel "word"
    chars.Push(letra); // cada letra que foi percorrida antes, se torna uma variavel "letra" que é adicionada a pilha "chars"

string reversedWord = string.Empty; // declarando uma nova variavel reversedWord como uma string
while (chars.Count > 0)
    reversedWord += chars.Pop(); // enquanto houver elementos na pilha "chars", o metodo Pop() remove o elemento do topo da pilha e retorna esse elemento, que é adicionado a variavel reversedWord

if (word.ToLower() == reversedWord.ToLower()) // "ToLower()" converte todos os caracteres da string para minusculo, assim a comparação não é afetada por letras maiusculas ou minusculas
    Console.WriteLine($"'{word}' é um palíndromo.");
else
    Console.WriteLine($"'{word}' não é um palíndromo.");