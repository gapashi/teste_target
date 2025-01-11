/*5) Escreva um programa que inverta os caracteres
 * de um string.

IMPORTANTE:
a) Essa string pode ser informada através de qualquer
entrada de sua preferência ou pode ser previamente
definida no código;
b) Evite usar funções prontas, como, por exemplo,
reverse;*/

internal class Conversao
{
    static void Main(string[] args)
    {
        Console.WriteLine("Bem-vindo!");
        Console.Write("Digite uma palavra: ");

        string palavra = Console.ReadLine()!;

        string inversao = "";

        for(int i = palavra.Length - 1; i >=0; i--)
        {
            inversao += palavra[i];
        }
        Console.WriteLine($"A palavra que digitou fica invertida dessa maneira: {inversao}");
    }
}