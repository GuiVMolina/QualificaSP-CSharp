/*
    Faça um programa que leia 6 valores. Estes valores serão
    somente negativos ou positivos (desconsidere os valores
    nulos). A seguir, mostre a quantidade de valores
    positivos digitados.

    Entrada
    Seis valores, negativos e/ou positivos.

    Saída
    Imprima uma mensagem dizendo quantos valores
    positivos foram lidos. 
*/
int pos = 0, neg = 0, zero = 0, i, n, x;
Console.WriteLine("Digite 6 valores e veremos quantos são negativos e quantos são positivos");

for (i = 0; i < 6; i++)
{
    n = i + 1;
    Console.Write("Qual será o " + n + "º valor? ");
    x = int.Parse(Console.ReadLine());
    if (x > 0) {pos++;}
    else if (x < 0){neg++;}
    else{zero++;}
}

if  (zero == 0)
{
    Console.WriteLine("\nHá entre esse valores:" +
    "\n" + pos + " número(s) positivo(s)" +
    "\n" + neg + " número(s) negativo(s)");
}
else
{
    Console.WriteLine("\nHá entre esse valores:" +
        "\n" + pos + " número(s) positivo(s)" +
        "\n" + neg + " número(s) negativo(s)" +
        "\nO zero apareceu " + zero + " vez(es)");
}