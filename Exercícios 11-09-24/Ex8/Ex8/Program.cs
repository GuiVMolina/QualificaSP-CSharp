/*
    Com base na tabela abaixo, escreva um programa
    que leia o código de um item e a quantidade deste
    item. A seguir, calcule e mostre o valor da conta a
    pagar.

    Entrada
    O arquivo de entrada contém dois valores inteiros
    correspondentes ao código e à quantidade de um
    item conforme tabela acima.

    Saída
    O arquivo de saída deve conter a mensagem "Total:
    R$ " seguido pelo valor a ser pago, com 2 casas
    após o ponto decimal.
*/
Console.Write("\tCantina" +
    "\n1\t Cachorro-quente\t R$4,00" +
    "\n2\t X-Salada\t\t R$4,50" +
    "\n3\t X-Bacon\t\t R$5,00" +
    "\n4\t Torrada Simples\t R$2,00" +
    "\n5\t Refrigerante\t\t R$1,50" +
    "\nQual opção você irá querer? ");
int lanche = int.Parse(Console.ReadLine());
Console.Write("Quantos vão ser? ");
int qnt = int.Parse(Console.ReadLine());

switch (lanche)
{
    case 1:
        Console.WriteLine(qnt + " Cachorro-quente(s) então? Vai sair R$" + qnt * 4.0 + ",00");
        break;
    case 2:
        Console.WriteLine(qnt + " X-Salada(s) então? Vai sair R$" + qnt * 4.5 + ",00");
        break;
    case 3:
        Console.WriteLine(qnt + " X-Bacon(s) então? Vai sair R$" + qnt * 5.0 + ",00");
        break;
    case 4:
        Console.WriteLine(qnt + " Torrada(s) simples então? Vai sair R$" + qnt * 2.0 + ",00");
        break;
    case 5:
        Console.WriteLine(qnt + "Refrigente(s) então? Vai sair R$" + qnt * 1.5 + ",00");
        break;
    default:
        Console.WriteLine("Não temos isso aqui senhor(a)");
        break;
}