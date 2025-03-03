/*
    Ler um número N e depois uma matriz
    quadrada NxN com números inteiros.
    Depois, mostrar na tela a soma dos
    elementos de cada linha da matriz.

    Entrada:
    A entrada contém o número N, depois os
    dados da matriz.

    Saída:
    A saída contém os números
    representando a soma dos elementos de
    cada linha da matriz.
*/
Console.Write("Valor de N: ");
int N = int.Parse(Console.ReadLine());
int[] soma = new int[N];
int[,] Matriz = new int[N, N];

for (int i = 0; i < N; i++)
{
    string[] vet = Console.ReadLine().Split(' ');
    for (int j = 0; j < N; j++)
    {
        Matriz[i, j] = int.Parse(vet[j]);
    }
}
Console.WriteLine("Soma dos valores:");
for (int i = 0; i < N; i++) {
    for (int j = 0; j < N; j++) {
        soma[i] += Matriz[i,j];
    }
    Console.WriteLine(soma[i]);
}