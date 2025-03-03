/*
    Crie um programa que solicite ao usuário um
    número inteiro e calcule a soma de todos os
    números pares de 2 até o número inserido usando
    um loop while.

    Entrada
    4

    Saída
    Deverá ser exibido na tela “A soma dos pares é: 6”
*/
int y = 0, total = 0;
Console.Write("Solicite um número: ");
int x = int.Parse(Console.ReadLine());
while (y <= x){
    if (y % 2 == 0){
        total += y;
    }
    y++;
}
Console.WriteLine("A soma dos pares é: " + total);