/*
    Leia um valor inteiro entre 1 e 12, inclusive.
    Correspondente a este valor, deve ser apresentado como
    resposta o mês do ano por extenso, em inglês, com a
    primeira letra maiúscula.

    Entrada
    A entrada contém um único valor inteiro.

    Saída
    Imprima por extenso o nome do mês correspondente ao
    número existente na entrada, com a primeira letra em
    maiúscula.
*/
Console.Write("Enter a number that corresponds to a month: ");
int month = int.Parse(Console.ReadLine());

switch (month)
{
    case 1:
        Console.WriteLine("This number (" + month + ") represents January");
        break;
    case 2:
        Console.WriteLine("This number (" + month + ") represents February");
        break;
    case 3:
        Console.WriteLine("This number (" + month + ") represents March");
        break;
    case 4:
        Console.WriteLine("This number (" + month + ") represents April");
        break;
    case 5:
        Console.WriteLine("This number (" + month + ") represents May");
        break;
    case 6:
        Console.WriteLine("This number (" + month + ") represents June");
        break;
    case 7:
        Console.WriteLine("This number (" + month + ") represents July");
        break;
    case 8:
        Console.WriteLine("This number (" + month + ") represents August");
        break;
    case 9:
        Console.WriteLine("This number (" + month + ") represents September");
        break;
    case 10:
        Console.WriteLine("This number (" + month + ") represents October");
        break;
    case 11:
        Console.WriteLine("This number (" + month + ") represents November");
        break;
    case 12:
        Console.WriteLine("This number (" + month + ") represents December");
        break;
    default:
        Console.WriteLine("This month doesnt exists...");
        break;
}