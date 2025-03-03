/*
    Neste problema, você deverá ler 3 palavras que definem o tipo de animal possível
    segundo o esquema abaixo, da esquerda para a direita. Em seguida, conclua qual
    dos animais seguintes foi escolhido, através das três palavras fornecidas.

    Entrada
    A entrada contém 3 palavras, uma em cada linha, necessárias para identificar o
    animal segundo a figura acima, com todas as letras minúsculas.

    Saída
    Imprima o nome do animal correspondente à entrada fornecida.
*/
string m, v, p;
Console.Write("Daremos um exemplo de animal conforme seu tipo, mas antes precisamos perguntar..." +
    "\nEle é vertebrado? ");
m = Console.ReadLine();
if (m == "sim")
{
    Console.Write("Ele é mamífero? ");
    v = Console.ReadLine();
    if (v == "sim")
    {
        Console.Write("Ele é onívoro? ");
        p = Console.ReadLine();
        if (p == "sim")
        {
            Console.WriteLine("Então é o homem");
        }
        else
        {
            Console.WriteLine("Então é uma vaca");
        }
    }
    else
    {
        Console.Write("Ele é carnívoro? ");
        p = Console.ReadLine();
        if (p == "sim")
        {
            Console.WriteLine("Então é uma águia");
        }
        else
        {
            Console.WriteLine("Então é uma pomba");
        }
    }
}
else
{
    Console.Write("Ele é um inseto? ");
    v = Console.ReadLine();
    if (v == "sim")
    {
        Console.Write("Ele é hematofogo? ");
        p = Console.ReadLine();
        if (p == "sim")
        {
            Console.WriteLine("Então é uma pulga");
        }
        else
        {
            Console.WriteLine("Então é uma lagarta");
        }
    }
    else
    {
        Console.Write("Ele é hematofogo? ");
        p = Console.ReadLine();
        if (p == "sim")
        {
            Console.WriteLine("Então é uma sanguessuga");
        }
        else
        {
            Console.WriteLine("Então é uma minhoca");
        }
    }
}