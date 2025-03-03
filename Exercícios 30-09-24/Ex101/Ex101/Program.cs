/*
    Leia um conjunto não determinado de pares
    de valores M e N (parar quando algum dos
    valores for menor ou igual a zero). Para cada
    par lido, mostre a sequência do menor até o
    maior e a soma dos inteiros consecutivos
    entre eles (incluindo o N e M).

    Entrada
    O arquivo de entrada contém um número não
    determinado de valores M e N. A última linha
    de entrada vai conter um número nulo ou
    negativo.

    Saída
    Para cada dupla de valores, imprima a
    sequência do menor até o maior e a soma
    deles, conforme exemplo ao lado.
*/
Console.Write("Qual é o conjunto de valores? ");
string[] nums = Console.ReadLine().Split();
int M = Convert.ToInt32(nums[0]);
int N = Convert.ToInt32(nums[1]);
int total = 0;
if (M >= N) {
    while (M >= N) {
        Console.WriteLine(N);
        total += N;
        N++;
    }
} else {
    while (N >= M) {
        Console.WriteLine(M);
        total += M;
        M++;
    }

}
Console.WriteLine("Soma = " + total);