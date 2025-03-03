8.
/*
    Escreva um programa que leia o número de um
    funcionário, seu número de horas trabalhadas, o
    valor que recebe por hora e calcula o salário desse
    funcionário. A seguir, mostre o número e o salário
    do funcionário, com duas casas decimais.

    Entrada
    O arquivo de entrada contém 2 números inteiros e
    1 número com duas casas decimais, representando
    o número, quantidade de horas trabalhadas e o
    valor que o funcionário recebe por hora trabalhada,
    respectivamente.

    Saída
    Imprima o número e o salário do funcionário,
    conforme exemplo fornecido, com um espaço em
    branco antes e depois da igualdade. No caso do
    salário, também deve haver um espaço em branco
    após o $.
*/
int num, horas, valor;
double salario;

Console.WriteLine("Qual o número do funcionário? ");
num = int.Parse(Console.ReadLine());

Console.WriteLine("Quantas horas esse funcionário trabalha? ");
horas = int.Parse(Console.ReadLine());

Console.WriteLine("Quanto esse funcionário ganha por hora trabalhada? ");
valor = int.Parse(Console.ReadLine());

salario = horas * valor;
Console.WriteLine("O funcionário de número " + num + " recebe um sálario de " + salario + "$");