/*
    Leia um valor inteiro N que é a quantidade de
    casos de teste que se segue. Cada caso de
    teste consiste em dois inteiros X e Y. Você
    deve apresentar a soma de todos os ímpares
    existentes entre X e Y.

    Entrada
    A primeira linha de entrada é um inteiro N
    que é a quantidade de casos de teste que se
    segue. Cada caso de teste consiste em uma
    linha contendo dois inteiros X e Y.

    Saída
    Imprima a soma de todos os valores ímpares
    entre X e Y.
*/
int X, Y, soma;
Console.Write("Quantos testes serão? ");
int N = int.Parse(Console.ReadLine());
for (int i = 0; i < N; i++) {
    soma = 0;
    Console.Write("Valor de X: ");
    X = int.Parse(Console.ReadLine());
    Console.Write("Valor de Y: ");
    Y = int.Parse(Console.ReadLine());
    if (X < Y) {
        for (int j = X + 1; j < Y; j++) {
            if (j % 2 != 0) {
                soma += j;
            }
        }
    } else {
        for (int j = Y + 1; j < X; j++) {
            if (j % 2 != 0) {
                soma += j;
            }
        }
    }
    Console.WriteLine(soma);
}