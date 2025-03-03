/*
    Leia 3 valores reais (A, B e C) e verifique se eles formam ou não
    um triângulo. Em caso positivo, calcule o perímetro do
    triângulo e apresente a mensagem:
    Perímetro = XX.X
    Em caso negativo, calcule a área do trapézio com A e B como
    base e C como altura, mostrando a mensagem
    Areá = XX.X
    Saída
    O resultado deve ser apresentado com uma casa decimal.
*/
double a = 0, b = 0, c = 0, total;
Console.Write("Qual é o valor de A? ");
double x = double.Parse(Console.ReadLine());
Console.Write("Qual é o valor de B? ");
double y = double.Parse(Console.ReadLine());
Console.Write("Qual é o valor de C? ");
double z = double.Parse(Console.ReadLine());

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
    total = ((x + y) * 2) / z;
    Console.WriteLine("Área: " + total);
}
else
{
    total = x + y + z;
    Console.WriteLine("Perímetro: " + total);
}