/*
    Fazer um programa para ler as medidas da base e altura de um retângulo.
    Em seguida, mostrar o valor da área, perímetro e diagonal deste retângulo,
    com quatro casas decimais, conforme exemplo.
*/
using System.Globalization;

double B, H, A, P, D;
Console.Write("Base: ");
B = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
Console.Write("Altura: ");
H = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

A = B * H;
Console.WriteLine("Área: " + A.ToString("F4", CultureInfo.InvariantCulture));

P = 2 * (B + H);
Console.WriteLine("Perímetro: " + P.ToString("F4", CultureInfo.InvariantCulture));

D = Math.Sqrt(Math.Pow(B, 2) + Math.Pow(H, 2));
Console.WriteLine("Diagonal: " + D.ToString("F4", CultureInfo.InvariantCulture));