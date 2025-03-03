/*
    Leia um valor de ponto flutuante com duas casas decimais.
    Este valor representa um valor monetário. A seguir, calcule o
    menor número de notas e moedas possíveis no qual o valor
    pode ser decomposto. As notas consideradas são de 100, 50,
    20, 10, 5, 2. As moedas possíveis são de 1, 0.50, 0.25, 0.10, 0.05
    e 0.01. A seguir mostre a relação de notas necessárias.

    Entrada
    O arquivo de entrada contém um valor de ponto flutuante N
    (0 ≤ N ≤ 1000000.00).

    Saída
    Imprima a quantidade mínima de notas e moedas
    necessárias para trocar o valor inicial, conforme exemplo
    fornecido.

    Obs: Utilize ponto (.) para separar a parte decimal.
*/
Console.Write("Qual a quantia de dinheiro que você possui? ");
double notas = double.Parse(Console.ReadLine());
double n = notas;
double notas100 = n / 100;
n = n - notas100 * 100;
double notas50 = n / 50;
n = n - notas50 * 50;
double notas20 = n / 20;
n = n - notas20 * 20;
double notas10 = n / 10;
n = n - notas10 * 10;
double notas5 = n / 5;
n = n - notas5 * 5;
double notas2 = n / 2;
n = n - notas2 * 2;
double m = n * 100;
double moedas100 = m / 100;
m = m - moedas100 * 100;
double moedas50 = m / 50;
m = m - moedas50 * 50;
double moedas25 = m / 25;
m = m - moedas25 * 25;
double moedas10 = m / 10;
m = m - moedas10 * 10;
double moedas5 = m / 5;
m = m - moedas5 * 5;
double moedas1 = m;

Console.WriteLine("NOTAS");
Console.WriteLine(notas100 + " nota(s) de R$ 100.00");
Console.WriteLine(notas50 + " nota(s) de R$ 50.00");
Console.WriteLine(notas20 + " nota(s) de R$ 20.00");
Console.WriteLine(notas10 + " nota(s) de R$ 10.00");
Console.WriteLine(notas5 + " nota(s) de R$ 5.00");
Console.WriteLine(notas2 + " nota(s) de R$ 2.00");
Console.WriteLine("MOEDAS");
Console.WriteLine(moedas100 + " moeda(s) de R$ 1,00");
Console.WriteLine(moedas50 + " moeda(s) de R$ 0,50");
Console.WriteLine(moedas25 + " moeda(s) de R$ 0,25");
Console.WriteLine(moedas10 + " moeda(s) de R$ 0,10");
Console.WriteLine(moedas5 + " moeda(s) de R$ 0,05");
Console.WriteLine(moedas1 + " moeda(s) de R$ 0,01");