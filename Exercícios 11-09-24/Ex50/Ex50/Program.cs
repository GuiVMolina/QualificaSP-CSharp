/*
    Leia um número inteiro que representa um código de DDD para discagem
    interurbana. Em seguida, informe à qual cidade o DDD pertence, considerando a
    tabela abaixo:
    Se a entrada for qualquer outro DDD que não esteja presente na tabela acima, o
    programa deverá informar:
    DDD não cadastrado

    Entrada
    A entrada consiste em um único valor inteiro.

    Saída
    Imprima o nome da cidade correspondente ao DDD existente na entrada.
    Imprima DDD não cadastrado caso não existir DDD correspondente ao número
    digitado.
*/
Console.WriteLine("Tabela de cidades:" +
    "\n61\tBrasília" +
    "\n71\tSalvador" +
    "\n11\tSão Paulo" +
    "\n21\tRio de Janeiro" +
    "\n32\tJuiz de Fora" +
    "\n19\tCampinas" +
    "\n27\tVitória" +
    "\n31\tBelo Horizonte" +
    "\nQual DDD você pretende verificar?");
int dc = int.Parse(Console.ReadLine());

switch (dc)
{
    case 11:
        Console.WriteLine("Esse DDD (" + dc + ") pertence à São Paulo");
        break;
    case 19:
        Console.WriteLine("Esse DDD (" + dc + ") pertence à Campinas");
        break;
    case 21:
        Console.WriteLine("Esse DDD (" + dc + ") pertence ao Rio de Janeiro");
        break;
    case 27:
        Console.WriteLine("Esse DDD (" + dc + ") pertence à Vitória");
        break;
    case 31:
        Console.WriteLine("Esse DDD (" + dc + ") pertence à Belo Horizonte");
        break;
    case 32:
        Console.WriteLine("Esse DDD (" + dc + ") pertence ao Juiz de Fora");
        break;
    case 61:
        Console.WriteLine("Esse DDD (" + dc + ") pertence à Brasília");
        break;
    case 71:
        Console.WriteLine("Esse DDD (" + dc + ") pertence ao Salvador");
        break;
    default:
        Console.WriteLine("DDD desconhecido...");
        break;
}