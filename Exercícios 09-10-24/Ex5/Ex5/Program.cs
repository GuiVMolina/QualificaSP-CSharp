/*
    Fazer um programa para ler duas matrizes
    de números inteiros A e B, contendo de M
    linhas e N colunas cada. Depois, gerar uma
    terceira matriz C onde cada elemento desta é
    a soma dos elementos correspondentes das
    matrizes originais.
    Imprimir na tela a matriz gerada.

    Entrada:
    A entrada contém os valores de M e N, depois
    os valores da primeira matriz A, depois os
    valores da segunda matriz B,
    conforme exemplo.

    Saída:
    A saída contém os valores da matriz gerada
    C, conforme exemplo.
*/
Console.Write("Valor de linhas das matrizes: ");
int L = int.Parse(Console.ReadLine());
Console.Write("Valor de colunas das matrizes: ");
int C = int.Parse(Console.ReadLine());
int[,] MatrizA = new int[L, C], MatrizB = new int[L, C], MatrizC = new int[L, C];

Console.WriteLine("Matriz A: ");
for (int i = 0; i < L; i++) {
    string[] vet = Console.ReadLine().Split(' ');
    for (int j = 0; j < C; j++) {
        MatrizA[i, j] = int.Parse(vet[j]);
    }
}

Console.WriteLine("Matriz B: ");
for (int i = 0; i < L; i++) {
    string[] vet = Console.ReadLine().Split(' ');
    for (int j = 0; j < C; j++) {
        MatrizB[i, j] = int.Parse(vet[j]);
    }
}

Console.WriteLine("Matriz C: ");
for (int i = 0; i < L; i++) {
    for (int j = 0; j < C; j++) {
        MatrizC[i,j] = MatrizA[i,j] + MatrizB[i,j];
        Console.Write(MatrizC[i,j] + " ");
    }
    Console.WriteLine();
}