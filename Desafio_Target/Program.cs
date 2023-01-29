// Online C# Editor for free
// Write, Edit and Run your C# code using C# Online Compiler
//Exercício 3

using Newtonsoft.Json;
//using System;
using System.Text.Json;
//using System.Collections;
//using System.Linq;
using Newtonsoft.Json.Serialization;
//using System.Reflection;
//using Newtonsoft.Json.Linq;
//using System.Text.Json.Nodes;
//using Microsoft.VisualBasic;
//using System.Security.Principal;

namespace DeserializeFromFile
{
    public class Faturamento
    {
        [JsonProperty("dia")]
        public int Date { get; set; }
        public double Valor { get; set; }

    }

    public class Program
    {
        public static async Task Main()
        {

            string fileName = @"./dados.json";
            string jsonString = File.ReadAllText(fileName);
            var faturamento = JsonConvert.DeserializeObject<List<Faturamento>>(jsonString);

            Console.WriteLine("Dados Json\n");

            foreach (var dados in faturamento)
            {
                Console.WriteLine(value: $"Dia: {dados.Date}");
                Console.WriteLine($"Valor: {dados.Valor}");
                Console.WriteLine("-------------");
            }

            Console.WriteLine("\nMenor valor do dia no mês:");
            //373,7838            
            foreach (var dados in faturamento)
            {
                double menorValor = 0;

                if (dados.Valor != menorValor && dados.Valor < 400)
                {
                    Console.WriteLine($"Dia: {dados.Date}" + $" Valor: {dados.Valor}");
                }

            }
            //48924,2448
            Console.WriteLine("\nMaior valor do dia:");

            foreach (var dados in faturamento)
            {
                if (dados.Valor > 48000)
                {
                    Console.WriteLine($"Dia: {dados.Date}" + $" Valor: {dados.Valor}");
                }

            }

            Console.WriteLine("\nMédia mensal:");

            int somaDias = 0;
            double mediaMensal = 0;
            foreach (var dados in faturamento)
            {
                if (dados.Valor != 0)
                {
                    somaDias++;
                    mediaMensal = (mediaMensal + dados.Valor) / somaDias;
                }
            }
            Console.WriteLine(Math.Round(mediaMensal, 4));

            Console.WriteLine("\nNúmero de dias do mês em que o faturamento superou a média mensal:");

            int somaDias2 = 0;
            foreach (var dados in faturamento)
            {

                if (dados.Valor > mediaMensal)
                {

                    Console.WriteLine($"Dia: {dados.Date}" + $" Valor: {dados.Valor}");
                    somaDias2++;

                }

            }
            Console.WriteLine("\nQuantidade de dias: " + somaDias2);


        }
    }
}

