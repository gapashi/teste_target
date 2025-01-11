/*2) Dado a sequência de Fibonacci, onde se inicia por
 * 0 e 1 e o próximo valor sempre será a soma dos 2
 * valores anteriores
 * (exemplo: 0, 1, 1, 2, 3, 5, 8, 13, 21, 34...),
 * escreva um programa na linguagem que desejar onde,
 * informado um número, ele calcule a sequência de
 * Fibonacci e retorne uma mensagem avisando se o
 * número informado pertence ou não a sequência.

IMPORTANTE: Esse número pode ser informado através
de qualquer entrada de sua preferência ou pode ser
previamente definido no código;*/
using System;
class Fibonacci
{
    static void Main(string[] args)
    {
        Console.Write("Digite um núemro inteiro: ");

        int numero = int.Parse(Console.ReadLine()!);

        bool pertenceSequencia = VerificaSequencia(numero);

        if(pertenceSequencia)
        {
            Console.WriteLine($"O número {numero} pertence à sequência de Fibonacci.");
        }
        else
        {
            Console.WriteLine($"O número {numero} não pertence à sequÊncia de Fibonacci");
        }
    }

    static bool VerificaSequencia(int num)
    {
        int a = 0, b = 1, soma = 0;

        while(soma < num)
        {
            soma = a + b;
            a = b;
            b = soma;
        }
        return soma == soma;
    }
}