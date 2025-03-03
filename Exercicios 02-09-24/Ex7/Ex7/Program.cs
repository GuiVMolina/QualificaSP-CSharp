7.
/*
    Leia quatro valores inteiros a, b, c e d. A seguir,
    calcule e mostre a diferença do produto de a e b
    pelo produto de c e d segundo a fórmula:
    DIFERENCA = (a * b - c * d).

    Entrada
    O arquivo de entrada contém 4 valores inteiros.

    Saída
    Imprima a mensagem DIFERENCA com todas as
    letras maiúsculas, conforme exemplo ao lado, com
    um espaço em branco antes e depois da igualdade.
*/
Console.WriteLine("Qual será o primeiro valor? ");
int a = int.Parse(Console.ReadLine());

Console.WriteLine("Qual será o segundo valor? ");
int b = int.Parse(Console.ReadLine());

Console.WriteLine("Qual será o terceiro valor? ");
int c = int.Parse(Console.ReadLine());

Console.WriteLine("Qual será o quarto valor? ");
int d = int.Parse(Console.ReadLine());

int dif = a * b - c * d;
Console.WriteLine("DIFERENÇA = " + dif);