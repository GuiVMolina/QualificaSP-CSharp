/*
    A empresa ABC resolveu conceder um aumento de salários a seus
    funcionários conforme a tabela abaixo:

    Leia o salário do funcionário e calcule e mostre o novo salário, bem
    como o valor de reajuste ganho e o índice reajustado, em percentual.

    Entrada
    A entrada contém apenas um valor de ponto flutuante, com duas casas
    decimais.

    Saída
    Imprima 3 linhas na saída: o novo salário, o valor ganho de reajuste
    (ambos devem ser apresentados com 2 casas decimais) e o percentual
    de reajuste ganho, conforme exemplo ao lado.
*/
string p = "";
double r;
Console.Write("Qual o seu salário atual? ");
double sal = double.Parse(Console.ReadLine());

if (sal >= 0 && sal <= 400.0)
{
    r = sal * 0.15;
    sal = sal * 1.15;
    p = "15%";
}
else if (sal >= 400.01 && sal <= 800.0)
{
    r = sal * 0.12;
    sal = sal * 1.12;
    p = "12%";
}
else if (sal >= 800.01 && sal <= 1200.0)
{
    r = sal * 0.1;
    sal = sal * 1.1;
    p = "10%";
}
else if (sal >= 1200.01 && sal <= 2000.0)
{
    r = sal * 0.07;
    sal = sal * 1.07;
    p = "7%";
}
else
{
    r = sal * 0.04;
    sal = sal * 1.04;
    p = "4%";
}
Console.WriteLine("Novo salário: " + sal +
    "\nReajuste ganho: " + r +
    "\nEm percentual: " + p);