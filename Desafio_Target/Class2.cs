// Online C# Editor for free
// Write, Edit and Run your C# code using C# Online Compiler
// Exercício 2
using System;

public class HelloWorld2
{
    public static void Main(string[] args)
    {

        int indice = 10, a = 0, b = 1, k = 0;

        Console.WriteLine("Digite um numero inteiro e saiba se ele faz parte da sequencia de fibonacci:");

        int numero = Convert.ToInt32(Console.ReadLine());

        for (int i = 0; i < indice; i++)
        {

            k = a;
            a = b;
            b = b + k;
            //Se não fizer parte da sequência de fibonacci, nada acontece além de mostrar a sequência.
            Console.WriteLine("Sequencia fibonacci: " + k);
            Console.WriteLine(k.Equals(numero) ? "Numero digitado: " + numero + ". Faz parte da sequencia fibonacci!" : "");
        }
    }
}
