/*
    Crie um programa que solicite ao usuário que
    insira números inteiros positivos repetidamente até
    que um número negativo seja inserido. Em
    seguida, exiba a soma dos números positivos
    inseridos.

    Entrada
    Entrar com números positivos ou entrar com um
    número negativo para encerrar

    Saída
    Deverá ser exibido na tela “A soma dos positivos”
*/
int total = 0;
Console.Write("Insira um número: ");
int x = int.Parse(Console.ReadLine());
do {
    total += x;
    Console.Write("Insira o próximo número: ");
    x = int.Parse(Console.ReadLine());
} while (x > 0);
Console.WriteLine("A soma dos positivos é: " + total);