/*
    Leia a hora inicial, minuto inicial, hora final e minuto final
    de um jogo. A seguir calcule a duração do jogo.

    Obs. O jogo tem duração mínima de um (1) minuto e
    duração máxima de 24 horas.

    Entrada
    Quatro números inteiros representando a hora de início
    e fim do jogo.

    Saída
    Mostre a seguinte mensagem: “O JOGO DUROU XXX
    HORA(S) E YYY MINUTO(S)” .
*/
int horas, minutos;
Console.Write("Que horas o jogo começou? ");
int h_inicio = int.Parse(Console.ReadLine());
Console.Write("Que horas o jogo terminou? ");
int h_final = int.Parse(Console.ReadLine());
Console.Write("Que minutos o jogo começou? ");
int m_inicio = int.Parse(Console.ReadLine());
Console.Write("Que minutos o jogo terminou? ");
int m_final = int.Parse(Console.ReadLine());

if (h_inicio == h_final)
{
    horas = 24;
    minutos = 0;
}
else if (h_inicio > h_final)
{
    horas = 24 - h_inicio + h_final;
}
else
{
    horas = h_final - h_inicio;
}

if (m_inicio == m_final)
{
    horas = 24;
    minutos = 0;
}
else if (m_inicio > m_final)
{
    minutos = 60 - m_inicio + m_final;
}
else
{
    minutos = m_final - m_inicio;
}
Console.WriteLine("O jogo durou " + horas + " hora(s) e " + minutos + " minuto(s)");