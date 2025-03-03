/*
    Faça um programa que o usuário informe o
    salário recebido e o total gasto.

    Entrada
    Salario e Gastos

    Saída
    Deverá ser exibido na tela “Gastos dentro do
    orçamento” caso o valor gasto não ultrapasse o
    valor do salário e “Orçamento estourado” se o
    valor gasto ultrapassar o valor do salário.
*/
Console.Write("Quanto você recebe? ");
double ganho = double.Parse(Console.ReadLine());

Console.Write("Quanto foi o seu gasto? ");
double gasto = double.Parse(Console.ReadLine());

if (gasto > ganho) {
    Console.WriteLine("Orçamento estourado");
}
else {
    Console.WriteLine("Gasto dentro do orçamento");
}