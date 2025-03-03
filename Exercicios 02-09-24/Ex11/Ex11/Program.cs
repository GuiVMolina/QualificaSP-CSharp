/*
    Rodrigo quer calcular e mostrar a quantidade de
    litros de combustível gastos em uma viagem, ao
    utilizar um automóvel que faz 12 KM/L. Para isso,
    ele gostaria que você o auxiliasse através de um
    simples programa. Para efetuar o cálculo, deve-se
    fornecer o tempo gasto na viagem (em horas) e a
    velocidade média durante a mesma (em km/h).
    Assim, pode-se obter distância percorrida e, em
    seguida, calcular quantos litros seriam necessários.
    Mostre o valor com 3 casas decimais após o ponto.

    Entrada
    O arquivo de entrada contém dois inteiros. O
    primeiro é o tempo gasto na viagem (em horas) e o
    segundo é a velocidade média durante a mesma
    (em km/h).

    Saída
    Imprima a quantidade de litros necessária para
    realizar a viagem, com três dígitos após o ponto
    decimal
*/
using System.Globalization;

const int gasto = 12;
int horas, velocidade, km;
Console.WriteLine("Qual foi o tempo gasto na viagem (horas)? ");
horas = int.Parse(Console.ReadLine());

Console.WriteLine("Qual foi a velocidade média durante a viagem (Km/h)? ");
velocidade = int.Parse(Console.ReadLine());

km = velocidade * horas;
double consumo = km / gasto;
Console.WriteLine("Esse carro precisará de cerca de " + consumo.ToString("F3", CultureInfo.InvariantCulture) + "L para realizar essa viagem");