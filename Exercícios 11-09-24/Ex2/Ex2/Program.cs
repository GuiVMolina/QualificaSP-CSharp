/*
    Desenvolva um programa que recebe do usuário, o
    placar de um jogo de futebol (os gols de cada time)
    e informa se o resultado foi um empate, se a vitória
    foi do primeiro time ou do segundo time.

    Entrada
    Time A
    Time B

    Saída
    Deverá ser exibido na tela "O resultado do jogo foi
    empate!“, ou "A vitória foi do time A“, A vitória foi do
    time B
*/
Console.Write("Quantos gols o time A fez? ");
double A = double.Parse(Console.ReadLine());
Console.Write("Quantos gols o time B fez? ");
double B = double.Parse(Console.ReadLine());

if (A > B)
{
    Console.WriteLine("A vitória foi do time A!");
}
else if (B > A)
{
    Console.WriteLine("A vitória foi do time B!");
}
else
{
    Console.WriteLine("O resultado do jogo foi empate!");
}