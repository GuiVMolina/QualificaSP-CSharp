/*
    Faça um programa que leia três valores e
    apresente o maior dos três valores lidos seguido da
    mensagem “eh o maior”. Utilize a fórmula:

    Obs.: a fórmula apenas calcula o maior entre os
    dois primeiros (a e b). Um segundo passo, portanto,
    é necessário para chegar no resultado esperado.

    Entrada
    O arquivo de entrada contém três valores inteiros.

    Saída
    Imprima o maior dos três valores seguido por um
    espaço e a mensagem "eh o maior".
*/
Console.Write("Qual é o primeiro valor? ");
int a = int.Parse(Console.ReadLine());

Console.Write("Qual é o segundo valor? ");
int b = int.Parse(Console.ReadLine());

Console.Write("Qual é o terceiro valor? ");
int c = int.Parse(Console.ReadLine());

if (a <= b && a <= c)
{
    Console.WriteLine(a + " é o maior");
}
else if (b <= c && b <= a)
{
    Console.WriteLine(b + " é o maior");
}
else
{
    Console.WriteLine(c + " é o maior");
}