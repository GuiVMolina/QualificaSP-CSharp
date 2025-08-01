﻿/*
    Leia quatro números (N1, N2, N3, N4), cada um deles com uma casa decimal, correspondente
    às quatro notas de um aluno. Calcule a média com pesos 2, 3, 4 e 1, respectivamente, para
    cada uma destas notas e mostre esta média acompanhada pela mensagem "Media: ". Se esta
    média for maior ou igual a 7.0, imprima a mensagem "Aluno aprovado.". Se a média calculada
    for inferior a 5.0, imprima a mensagem "Aluno reprovado.". Se a média calculada for um valor
    entre 5.0 e 6.9, inclusive estas, o programa deve imprimir a mensagem "Aluno em exame.".

    No caso do aluno estar em exame, leia um valor correspondente à nota do exame obtida pelo
    aluno. Imprima então a mensagem "Nota do exame: " acompanhada pela nota digitada.
    Recalcule a média (some a pontuação do exame com a média anteriormente calculada e divida
    por 2). e imprima a mensagem "Aluno aprovado." (caso a média final seja 5.0 ou mais ) ou
    "Aluno reprovado.", (caso a média tenha ficado 4.9 ou menos). Para estes dois casos (aprovado
    ou reprovado após ter pego exame) apresente na última linha uma mensagem "Media final: "
    seguido da média final para esse aluno.

    Entrada
    A entrada contém quatro números de ponto flutuante correspondentes as notas dos alunos.

    Saída
    Todas as respostas devem ser apresentadas com uma casa decimal. As mensagens devem ser
    impressas conforme a descrição do problema.
*/
int i, j;
double media, exame;
double[] n = new double[4];
for (i = 0; i <= 3; i++)
{
    j = i + 1;
    Console.Write("Qual foi sua " + j + "º nota? ");
    n[i] = double.Parse(Console.ReadLine());
}

media = ((n[0] * 2) + (n[1] * 3) + (n[2] * 4) + n[3]) / 10;
if (media >= 7.0)
{
    Console.WriteLine("Aluno aprovado");
}
else if (media < 5.0)
{
    Console.WriteLine("Aluno reprovado");
}
else
{
    Console.WriteLine("Você está de exame! Qual foi sua nota no exame? ");
    exame = double.Parse(Console.ReadLine());
    media = (exame + media) / 2;
    if (media >= 5.0)
    {
        Console.WriteLine("Aluno aprovado");
    }
    else
    {
        Console.WriteLine("Aluno reprovado");
    }
}
Console.WriteLine("Média final: " + media.ToString("F1"));