/* 1) Observe o trecho de código abaixo: int INDICE = 13, SOMA = 0, K = 0;
Enquanto K < INDICE faça { K = K + 1; SOMA = SOMA + K; }
Imprimir(SOMA);
Ao final do processamento, qual será o valor da variável SOMA? */

Console.WriteLine("Bem-vindo!");
Console.Write("Digite um número: ");

int numero  = int.Parse(Console.ReadLine());

int soma = 0;
int k = 0;
int indice = 13;

while(k < indice)
{
    k = k + 1;
    soma = soma + k;
}

Console.WriteLine($"O valor de SOMA é: {soma}");
