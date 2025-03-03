/*
    Escreva um programa que pergunte o dia, mês e
    ano do aniversário de uma pessoa e diga se a data
    é válida ou não. Caso não seja, diga o motivo.
    Suponha que todos os meses tem 31 dias e que
    estejamos no ano de 2013.

    Entrada
    Dia, Mês e Ano.

    Saída
    Deverá ser exibido na tela “Data válida” ou “Data
    Inválida”.
*/
Console.Write("Vamos ver se sua data de aniversário é válida\nDia: ");
int dia = int.Parse(Console.ReadLine());
Console.Write("Mês: ");
int mes = int.Parse(Console.ReadLine());
Console.Write("Ano: ");
int ano = int.Parse(Console.ReadLine());

if (dia > 0 && dia <= 31 && mes > 0 && mes <= 12 && ano > 0 && ano <= 2013)
{
    Console.WriteLine("Data válida");
}
else
{
    Console.WriteLine("Data inválida");
}