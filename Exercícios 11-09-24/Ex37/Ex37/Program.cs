﻿/*
    Você deve fazer um programa que leia um valor qualquer e apresente
    uma mensagem dizendo em qual dos seguintes intervalos ([0,25],
    [25,50], [50,75], [75,100] este valor se encontra. Obviamente, se o
    valor não estiver em nenhum destes intervalos, deverá ser impressa a
    mensagem “Fora de intervalo”.

    O símbolo (representa "maior que“). Por exemplo:
    [0,25] indica valores entre 0 e 25.0000, inclusive eles.
    [25,50] indica valores maiores que 25 Ex: 25.00001 até o valor
    50.0000000

    Entrada
    O arquivo de entrada contém um número com ponto flutuante
    qualquer.

    Saída
    A saída deve ser uma mensagem conforme exemplo abaixo.
*/
Console.Write("Digite o valor: ");
double valor = double.Parse(Console.ReadLine());

if (valor >= 0.0 && valor <= 25.0)
{
    Console.WriteLine("Valor entre o intervalo [0,25]");
}
else if (valor > 25.0 && valor <= 50.0)
{
    Console.WriteLine("Valor entre o intervalo [25,50]");
}
else if (valor > 50.0 && valor <= 75.0)
{
    Console.WriteLine("Valor entre o intervalo [50,75]");
}
else if (valor > 75.0 && valor <= 100.0)
{
    Console.WriteLine("Valor entre o intervalo [75,100]");
}
else
{
    Console.WriteLine("Valor fora do intervalo!");
}