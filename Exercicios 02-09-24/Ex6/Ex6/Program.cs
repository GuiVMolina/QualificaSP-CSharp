/*
    Leia quatro valores inteiros a, b, c e d. A seguir,
    calcule e mostre a diferença do produto de a e b
    pelo produto de c e d segundo a fórmula:
    DIFERENCA = (a * b - c * d).

    Entrada
    O arquivo de entrada contém 4 valores inteiros.

    Saída
    Imprima a mensagem DIFERENCA com todas as
    letras maiúsculas, conforme exemplo ao lado, com
    um espaço em branco antes e depois da igualdade.
*/
using System.Globalization;

const double P1 = 2;
const double P2 = 3;
const double P3 = 5;
const double MEDIA = P1 + P2 + P3;
Console.WriteLine("Qual foi a sua primeira nota? ");
double a = double.Parse(Console.ReadLine());
a = a * P1;

Console.WriteLine("Qual foi a sua segunda nota? ");
double b = double.Parse(Console.ReadLine());
b = b * P2;

Console.WriteLine("Qual foi a sua terceira nota? ");
double c = double.Parse(Console.ReadLine());
c = c * P3;

double mediaPonderada = (a + b + c) / MEDIA;
Console.WriteLine("MEDIA = " + mediaPonderada.ToString("F1", CultureInfo.InvariantCulture));