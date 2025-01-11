/*4) Dado o valor de faturamento mensal de
 * uma distribuidora, detalhado por estado:
• SP – R$67.836,43
• RJ – R$36.678,66
• MG – R$29.229,88
• ES – R$27.165,48
• Outros – R$19.849,53

Escreva um programa na linguagem que desejar
onde calcule o percentual de representação
que cada estado teve dentro do
valor total mensal da distribuidora. */

using System;

class Percentual
{
    static void Main()
    {
        double sp = 67836.43;
        double rj = 36678.66;
        double mg = 29229.88;
        double es = 27165.48;
        double outros = 19849.53;

        double faturamento = sp + rj + mg + outros;

        double porcentagemSp = (sp / faturamento) * 100;
        double porcentagemRj = (rj / faturamento) * 100;
        double porcentagemMg = (mg / faturamento) * 100;
        double porcentagemEs = (es / faturamento) * 100;
        double porcentagemOutros = (outros / faturamento) * 100;

        Console.WriteLine("Percentuais mensais:\n");
        Console.WriteLine($"São Paulo: {porcentagemSp:F2}%");
        Console.WriteLine($"Rio de Janeiro: {porcentagemRj:F2}%");
        Console.WriteLine($"Minas Gerais: {porcentagemMg:F2}%");
        Console.WriteLine($"Espírito Santo: {porcentagemEs:F2}%");
        Console.WriteLine($"Outros: {porcentagemOutros:F2}5");
    }
}