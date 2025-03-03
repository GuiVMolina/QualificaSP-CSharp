Console.Write("Insira o número correspondente a um dia da semana: ");
int num = int.Parse(Console.ReadLine());
string dia = "";

switch (num) {
    case 1:
        dia = "Domingo";
        break;

    case 2:
        dia = "Segunda";
        break;

    case 3:
        dia = "Terça";
        break;

    case 4:
        dia = "Quarta";
        break;

    case 5:
        dia = "Quinta";
        break;

    case 6:
        dia = "Sexta";
        break;

    case 7:
        dia = "Sábado";
        break;

    default:
        dia = "Indefinido";
        Console.WriteLine("Valor desconhecido");
        break;                            
}
Console.WriteLine("Dia da semana: " + dia);
Console.ReadKey();