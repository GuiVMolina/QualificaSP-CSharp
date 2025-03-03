/*
    Leia 2 valores com uma casa decimal (x e y), que devem representar as
    coordenadas de um ponto em um plano. A seguir, determine qual o quadrante
    ao, qual pertence o ponto, ou se está sobre um dos eixos cartesianos ou na
    origem
    (x = y = 0).

    Se o ponto estiver na origem, escreva a mensagem “Origem”.
    Se o ponto estiver sobre um dos eixos escreva “Eixo X” ou “Eixo Y”, conforme for a
    situação.

    Entrada
    A entrada contem as coordenadas de um ponto.

    Saída
    A saída deve apresentar o quadrante em que o ponto se encontra.
*/
Console.Write("Qual a posição do X? ");
double x = double.Parse(Console.ReadLine());
Console.Write("Qual a posição do Y? ");
double y = double.Parse(Console.ReadLine());

if (x == 0 && y == 0)
{
    Console.WriteLine("Ponto de origem");
}
else
{
    if (x == 0)
    {
        Console.WriteLine("Eixo X");
    }
    else if (y == 0)
    {
        Console.WriteLine("Eixo Y");
    }
    else if (x > 0 && y > 0)
    {
        Console.WriteLine("Quadrante 1");
    }
    else if (x < 0 && y > 0)
    {
        Console.WriteLine("Quadrante 2");
    }
    else if (x < 0 && y < 0)
    {
        Console.WriteLine("Quadrante 3");
    }
    else
    {
        Console.WriteLine("Quadrante 4");
    }
}