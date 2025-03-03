/*
    Ler um inteiro N e uma matriz quadrada
    de ordem N. Mostrar a soma dos
    elementos acima da diagonal principal.

    Entrada:
    A entrada contém o valor N, depois os
    dados da matriz.

    Saída:
    A saída contém a soma dos elementos
    da diagonal principal.
*/
Console.Write("Valor de N: ");
int N = int.Parse(Console.ReadLine());
int[,] Matriz = new int[N, N];
int soma = 0;

for (int i = 0; i < N; i++) {
    string[] vet = Console.ReadLine().Split(' ');
    for (int j = 0; j < N; j++) {
        Matriz[i, j] = int.Parse(vet[j]);
    }
}
for (int i = 0; i < N; i++) {
    for (int j = i + 1;  j < N; j++) {
        soma += Matriz[i, j];
    }
}
Console.Write("Soma dos elementos acima da diagonal principal: " + soma);