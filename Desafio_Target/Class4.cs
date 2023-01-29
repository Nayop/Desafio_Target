// Online C# Editor for free
// Write, Edit and Run your C# code using C# Online Compiler
// Exercício 5
using System;
public class HelloWorld5
{
    public static void Main(string[] args)
    {

        string palavra = "";

        Console.Write("Digite uma palavra:\n");
        string leitura = Console.ReadLine();

        int Length = leitura.Length - 1;

        while (Length >= 0)
        {
            palavra = palavra + leitura[Length];
            Length--;
        }
        Console.WriteLine("Palavra invertida: " + palavra);
    }

}