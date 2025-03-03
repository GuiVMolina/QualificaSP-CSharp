/*
    Leia os quatro valores correspondentes aos eixos x
    e y de dois pontos quaisquer no plano, p1(x1, y1) e
    p2(x2, y2) e calcule a distância entre eles, mostrando
    4 casas decimais após a vírgula.

    Entrada
    O arquivo de entrada contém quatro linhas de
    dados. As duas primeiras linhas contém dois
    valores de ponto flutuante: x1 y1 e as duas segundas
    linhas contém dois valores de ponto flutuante x2
    y2.
    Saída
    Calcule e imprima o valor da distância segundo a
    fórmula fornecida, com 4 casas após o ponto
    decimal.
*/
Console.Write("Em que ponto se encontrar o x1? ");
double x1 = double.Parse(Console.ReadLine());

Console.Write("Em que ponto se encontrar o y1? ");
double y1 = double.Parse(Console.ReadLine());

Console.Write("Em que ponto se encontrar o x2? ");
double x2 = double.Parse(Console.ReadLine());

Console.Write("Em que ponto se encontrar o y2? ");
double y2 = double.Parse(Console.ReadLine());

double distancia = Math.Sqrt(Math.Pow((x2 - x1), 2) + Math.Pow((y2 - y1), 2));
Console.WriteLine("A distância entre esses pontos é " + distancia.ToString("F4"));