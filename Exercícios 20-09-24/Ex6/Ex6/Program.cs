/*
    Faça um programa que calcule o IMC
    recebendo o nome, peso e altura de uma pessoa
    Ao final imprima o resultado no console.

    Entrada
    O arquivo de entrada contém:
    Nome: Rodrigo
    Peso: 79
    Altura: 1.82

    Saída
    Calcule e imprima o valor do IMC arredondando
    esse valor.
*/
Console.Write("Nome: ");
string nome = Console.ReadLine();

Console.Write("Peso: ");
int peso = int.Parse(Console.ReadLine());

Console.Write("Altura: ");
double altura = double.Parse(Console.ReadLine());

double imc = peso / Math.Pow(altura, 2);
Console.WriteLine("IMC: " + Math.Round(imc, 0, MidpointRounding.ToEven));