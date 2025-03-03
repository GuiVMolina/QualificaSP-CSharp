/*
    Faça um programa que leia 5 valores inteiros. Conte
    quantos destes valores digitados são pares e mostre esta
    informação.

    Entrada
    O arquivo de entrada contém 5 valores inteiros
    quaisquer.

    Saída
    Imprima a mensagem conforme o exemplo fornecido,
    indicando a quantidade de valores pares lidos.
*/
int par = 0, imp = 0, i, n, x;
Console.WriteLine("Digite 5 valores e veremos quais são pares e quais são ímpares");

for (i = 0; i < 5; i++)
{
    n = i + 1;
    Console.Write("Qual será o " + n + "º valor? ");
    x = int.Parse(Console.ReadLine());
    if (x % 2 == 0) { par++; }
    else { imp++; }
}

if (par == 0)
{
    Console.WriteLine("\nTodos os valores são ímpares");
}
else if (imp == 0)
{
    Console.WriteLine("\nTodos os valores são pares");
}
else
{
    Console.WriteLine("\nHá entre esse valores:" +
        "\n" + par + " número(s) par(es)" +
        "\n" + imp + " número(s) ímpar(es)");
}