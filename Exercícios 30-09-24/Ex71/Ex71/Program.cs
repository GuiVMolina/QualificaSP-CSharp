/*
    Leia 2 valores inteiros X e Y. A seguir, calcule e
    mostre a soma dos números impares entre eles.

    Entrada
    O arquivo de entrada contém dois valores inteiros.

    Saída
    O programa deve imprimir um valor inteiro. Este
    valor é a soma dos valores ímpares que estão entre
    os valores fornecidos na entrada que deverá caber
    em um inteiro.
*/
int soma = 0;
Console.Write("Qual será o valor de X? ");
int X = int.Parse(Console.ReadLine());
Console.Write("Qual será o valor de Y? ");
int Y = int.Parse(Console.ReadLine());

if (X < Y) {
    for (int i = X++; i < Y; i++) {
        if (i % 2 != 0) {
            soma += i;
        }
    }
} else {
    for (int i = Y++; i < X; i++) {
        if (i % 2 != 0) {
            soma += i;
        }
    }
}
Console.WriteLine("Soma dos ímpares entre eles: " + soma);