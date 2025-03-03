/*
    Leia a hora inicial e a hora final de um jogo. A seguir calcule a
    duração do jogo, sabendo que o mesmo pode começar em um
    dia e terminar em outro, tendo uma duração mínima de 1 hora
    e máxima de 24 horas.

    Entrada
    A entrada contém dois valores inteiros representando a hora de
    início e a hora de fim do jogo.

    Saída
    Apresente a duração do jogo conforme exemplo ao lado.
*/
int horas;
Console.Write("Que horas esse jogo começou? ");
int inicio = int.Parse(Console.ReadLine());
Console.Write("Que horas esse jogo terminou? ");
int final = int.Parse(Console.ReadLine());

if (inicio > final)
{
    horas = 24 - inicio + final;
}
else
{
    horas = final - inicio;
}
Console.WriteLine("Esse jogo durou " + horas + " hora(s)");