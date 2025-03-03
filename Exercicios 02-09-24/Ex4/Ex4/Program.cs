4.
/*
    Leia dois valores inteiros. A seguir, calcule o
    produto entre estes dois valores e atribua esta
    operação à variável prod. A seguir mostre a variável
    prod com mensagem correspondente.

    Entrada
    O arquivo de entrada contém 2 valores inteiros.

    Saída
    Imprima a mensagem "PROD" e a variável prod
    conforme exemplo ao lado, com um espaço em
    branco antes e depois da igualdade. Não esqueça
    de imprimir o fim de linha após o produto.
*/
Console.WriteLine("Qual será o primeiro valor? ");
int a = int.Parse(Console.ReadLine());

Console.WriteLine("Qual será o segundo valor? ");
int b = int.Parse(Console.ReadLine());

int prod = a + b;
Console.WriteLine("PROD = " + prod);