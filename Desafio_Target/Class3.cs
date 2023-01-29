// Online C# Editor for free
// Write, Edit and Run your C# code using C# Online Compiler
// Exercício 4

using System;
using System.Collections.Generic;


public class HelloWorld4
{
    public static void Main(string[] args)
    {

        Dictionary<string, double> listaFaturamento = new Dictionary<string, double>();
        listaFaturamento.Add("SP", 67836.43);
        listaFaturamento.Add("RJ", 36878.66);
        listaFaturamento.Add("MG", 29229.88);
        listaFaturamento.Add("ES", 27165.48);
        listaFaturamento.Add("OUTROS", 19849.53);

        Console.WriteLine("Valor tota mensal da distribuidora por estado: \n");

        foreach (KeyValuePair<string, double> estadoValor in listaFaturamento)
        {
            Console.WriteLine("Estado: {0}, Valor: {1}",
                estadoValor.Key, estadoValor.Value);
        }

        Console.WriteLine("\nValor total mensal de todos os estados: ");

        double total = 0;

        foreach (KeyValuePair<string, double> valorTotal in listaFaturamento)
        {
            total = total + valorTotal.Value;
        }
        Console.WriteLine(total + "\n");

        double porcentagem = 0;

        Console.WriteLine("\nPercentual de faturamento de todos os estados: ");

        foreach (KeyValuePair<string, double> calculadora in listaFaturamento)
        {
            porcentagem = (calculadora.Value / total) * 100;
            Console.WriteLine("Estado: {0}, Porcentagem: {1}%", calculadora.Key, Math.Round(porcentagem, 0));
        }

    }
}