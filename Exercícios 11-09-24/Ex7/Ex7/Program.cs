/*
    Leia 4 valores inteiros A, B, C e D.
    A seguir, se B for maior que C e se D for maior que
    A, e a soma de C com D for maior que a soma de A
    e B e se C e D, ambos, forem positivos e se a
    variável A for par escrever a mensagem "Valores
    aceitos", senão escrever "Valores não aceitos".

    Entrada
    Quatro números inteiros A, B, C e D.

    Saída
    Mostre a respectiva mensagem após a validação
    dos valores.
*/
Console.Write("Qual o valor de A? ");
int A = int.Parse(Console.ReadLine());
Console.Write("Qual o valor de B? ");
int B = int.Parse(Console.ReadLine());
Console.Write("Qual o valor de C? ");
int C = int.Parse(Console.ReadLine());
Console.Write("Qual o valor de D? ");
int D = int.Parse(Console.ReadLine());

if (B > C && D > A && C + D > A + B && C >= 0 && D >= 0 && A % 2 == 0)
{
    Console.WriteLine("Valores aceitos");
}
else
{
    Console.WriteLine("Valores não aceitos");
}