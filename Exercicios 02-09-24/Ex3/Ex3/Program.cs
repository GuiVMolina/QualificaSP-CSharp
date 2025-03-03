3.
/*
    Leia dois valores inteiros, no caso para variáveis a e
    b. A seguir, calcule a soma entre elas e atribua à
    variável soma. A seguir escrever o valor desta
    variável.

    Entrada
    O arquivo de entrada contém 2 valores inteiros.

    Saída
    Imprima a mensagem "SOMA" com todas as letras
    maiúsculas, com um espaço em branco antes e
    depois da igualdade seguido pelo valor
    correspondente à soma dê a e b. Como todos os
    problemas, não esqueça de imprimir o fim de linha
    após o resultado.
*/
Console.WriteLine("Qual será o primeiro valor? ");
int a = int.Parse(Console.ReadLine());

Console.WriteLine("Qual será o segundo valor? ");
int b = int.Parse(Console.ReadLine());

int soma = a + b;
Console.WriteLine("SOMA = " + soma);