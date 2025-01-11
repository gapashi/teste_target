using System;
using System.IO;
using System.Linq;
using System.Collections.Generic;

class Distribuidora
{
    static void Main()
    {
        string [] linhas = File.ReadAllLines("dados.json");

        List<double> faturamento = new List<double>();

        foreach (var linha in linhas)
        {
            if (linha.Contains("faturamento"))
            {
                string valor = linha.Split(':')[1].Trim().TrimEnd('}', ',');
                if (double.TryParse(valor, out double faturamentoDia))
                {
                    faturamento.Add(faturamentoDia);
                }
            }
        }

        var faturamentosValidos = faturamento.Where(f => f > 0).ToList();

        double menorFaturamento = faturamentosValidos.Min();
        double maiorFaturamento = faturamentosValidos.Max();
        double mediaMensal = faturamentosValidos.Average();
        int diasAcimaDaMedia = faturamentosValidos.Count(f => f > mediaMensal);

        Console.WriteLine($"Menor Faturamento: {menorFaturamento}");
        Console.WriteLine($"Maior Faturamento: {maiorFaturamento}");
        Console.WriteLine($"Número de dias acima da média mensal: {diasAcimaDaMedia}");
    }
}