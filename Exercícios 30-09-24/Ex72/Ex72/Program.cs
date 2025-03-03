/*
    Leia um valor inteiro N. Este valor será a
    quantidade de valores inteiros X que serão lidos em
    seguida.
    Mostre quantos destes valores X estão dentro do
    intervalo [10,20] e quantos estão fora do intervalo,
    mostrando essas informações.

    Entrada
    A primeira linha da entrada contém um valor
    inteiro N (N < 10000), que indica o número de casos
    de teste.
    Cada caso de teste a seguir é um valor inteiro X (-
    107 < X <107).

    Saída
    Para cada caso, imprima quantos números estão
    dentro (in) e quantos valores estão fora (out) do
    intervalo.
*/
int IN = 0, OUT = 0, X;
Console.Write("Quantos valores serão lidos? ");
int N = int.Parse(Console.ReadLine());
for (int i = 0; i < N; i++) {
    Console.Write("Qual será o " + N + "º valor? ");
    X = int.Parse(Console.ReadLine());
    if (X >= 10 && X <= 20) {
        IN++;
    } else {
        OUT++;
    }
}
Console.WriteLine("Valores dentro: " + IN);
Console.WriteLine("Valores fora: " + OUT);