/*
    Leia 2 valores inteiros (A e B).
    Após, o programa deve mostrar uma mensagem "São
    Múltiplos" ou "Não são Múltiplos", indicando se os
    valores lidos são múltiplos entre si.
*/
Console.Write("Qual o valor de A? ");
int A = int.Parse(Console.ReadLine());
Console.Write("Qual o valor de B? ");
int B = int.Parse(Console.ReadLine());

if (A % B == 0 || B % A == 0)
{
    Console.WriteLine("São múltiplos");
}
else
{
    Console.WriteLine("Não são múltiplos");
}