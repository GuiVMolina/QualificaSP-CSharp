/*
    Escreva um programa que leia dois valores X e
    Y. A seguir, mostre uma sequência de 1 até Y,
    passando para a próxima linha a cada X
    números.

    Entrada
    O arquivo de entrada contém dois valores
    inteiros, (1 < X < 20) e (X < Y < 100000).

    Saída
    Cada sequência deve ser impressa em uma
    linha apenas, com 1 espaço em branco entre
    cada número, conforme exemplo abaixo. Não
    deve haver espaço em branco após o último
    valor da linha.
*/
Console.Write("Qual é o valor de X? ");
int X = int.Parse(Console.ReadLine());
Console.Write("Qual é o valor de Y? ");
int Y = int.Parse(Console.ReadLine());
int j = 0;
for (int i = 1; i <= Y; i++) {
    if (X - 1 == j) {
        j = 0;
        Console.WriteLine(i);
    } else {
        j++;
        Console.Write(i + " ");
    }
}