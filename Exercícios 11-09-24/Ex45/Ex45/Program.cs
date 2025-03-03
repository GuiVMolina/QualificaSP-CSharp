/*
    Leia 3 valores de ponto flutuante A, B e C e ordene-os em ordem decrescente, de
    modo que o lado A representa o maior dos 3 lados. A seguir, determine o tipo de
    triângulo que estes três lados formam, com base nos seguintes casos, sempre
    escrevendo uma mensagem adequada:
    se A ≥ B+C, apresente a mensagem: NÃO FORMA TRIANGULO
    se A2 = B2 + C2, apresente a mensagem: TRIANGULO RETÂNGULO
    se A2 > B2 + C2, apresente a mensagem: TRIANGULO OBTUSÂNGULO
    se A2 < B2 + C2, apresente a mensagem: TRIANGULO ACUTÂNGULO
    se os três lados forem iguais, apresente a mensagem: TRIANGULO EQUILÁTERO
    se apenas dois dos lados forem iguais, apresente a mensagem: TRIANGULO
    ISÓSCELES

    Entrada
    A entrada contem três valores de ponto flutuante de dupla precisão A (0 < A) , B
    (0 < B) e C (0 < C).

    Saída
    Imprima todas as classificações do triângulo especificado na entrada.
*/
double a = 0, b = 0, c = 0, x, y, z;
Console.Write("Determinaremos o tipo de triângulo... \nQual o valor de A? ");
x = double.Parse(Console.ReadLine());
Console.Write("Qual o valor de B? ");
y = double.Parse(Console.ReadLine());
Console.Write("Qual o valor de C? ");
z = double.Parse(Console.ReadLine());

if (x >= y && x >= z)
{
    a = x; b = y; c = z;
}

else if (y >= x && y >= z)
{
    a = y; b = x; c = z;
}

else if (z >= x && z >= y)
{
    a = z; b = x; c = y;
}

if (a >= b + c)
{
    Console.WriteLine("Não forma triângulo");
}
else
{
    if (Math.Pow(a, 2) == Math.Pow(b, 2) + Math.Pow(c, 2))
    {
        Console.WriteLine("Triângulo retângulo");
    }
    else if (Math.Pow(a,2) > Math.Pow(b, 2) + Math.Pow(c, 2))
    {
        Console.WriteLine("Triângulo obtusângulo");
    }
    else if (Math.Pow(a, 2) < Math.Pow(b, 2) + Math.Pow(c, 2))
    {
        Console.WriteLine("Triângulo acutângulo");
    }
    if (a == b && a == c)
    {
        Console.WriteLine("Triângulo equilátero");
    }
    else if ((a == b && a != c) || (a == c && a != b) || (b == c && b != a))
    {
        Console.WriteLine("Triângulo isósceles");
    }
}