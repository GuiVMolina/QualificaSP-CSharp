/*
    Leia 3 valores inteiros e ordene-os em ordem crescente.
    No final, mostre os valores em ordem crescente, uma
    linha em branco e em seguida, os valores na sequência
    como foram lidos.
    Entrada
    A entrada contem três números inteiros.
    Saída
    Imprima a saída conforme foi especificado.
*/
int a, b, c, x, y, z;
Console.Write("Qual é o primero valor? ");
a = int.Parse(Console.ReadLine());
Console.Write("Qual é o segundo valor? ");
b = int.Parse(Console.ReadLine());
Console.Write("Qual é o terceiro valor? ");
c = int.Parse(Console.ReadLine());

if (a < b && a < c)
{
    if (b < c)
    {
        x = a; y = b; z = c;
    }
    else
    {
        x = a; y = c; z = b;
    }
}
else if (b < c)
{
    if (a < c)
    {
        x = b; y = a; z = c;
    }
    else
    {
        x = b; y = c; z = a;
    }
}
else
{
    if (a < b)
    {
        x = c; y = a; z = b;
    }
    else
    {
        x = c; y = b; z = a;
    }
}
Console.Write("Conforme especificado: " + a + " " + b + " " + c +
    "\nEm ordem crescente: " + x + " " + y + " " + z);