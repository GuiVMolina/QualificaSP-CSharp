/*
    Ler uma matriz quadrada de ordem N, contendo números
    reais. Em seguida, fazer as seguintes ações:
    a) calcular e imprimir a soma de todos os elementos
    positivos da matriz.
    b) fazer a leitura do índice de uma linha da matriz e, daí,
    imprimir todos os elementos desta linha.
    c) fazer a leitura do índice de uma coluna da matriz e, daí,
    imprimir todos os elementos desta coluna.
    d) imprimir os elementos da diagonal principal da matriz.
    e) alterar a matriz elevando ao quadrado todos os
    números negativos da mesma. Em seguida imprimir a
    matriz alterada.
    Entrada:
    A entrada contém o número inteiro N, seguido dos valores
    da matriz com uma casa decimal cada, seguido do índice
    de uma linha, seguido do índice de uma coluna, conforma
    exemplo.
    Saída:
    A saída contém os valores de saída de cada ação, com
    uma casa decimal, na ordem em que foram apresentadas
    no enunciado, conforme exemplo.
*/
Console.Write("Valor de N: ");
int N = int.Parse(Console.ReadLine());
double[,] Matriz = new double[N, N];
double soma = 0;

for (int i = 0; i < N; i++) {
    string[] vet = Console.ReadLine().Split(' ');
    for (int j = 0; j < N; j++) {
        Matriz[i, j] = int.Parse(vet[j]);
    }
}
for (int i = 0; i < N; i++){
    for (int j = 0; j < N; j++) {
        if (Matriz[i, j] > 0) {
            soma += Matriz[i, j];
        }
    }
}
Console.Write("Soma dos valores positivos: " + soma);

Console.Write("\nQual linha você deseja ver? ");
int linha = int.Parse(Console.ReadLine());
for (int j = 0; j < N; j++) {
    Console.Write(Matriz[linha, j] + " ");
}

Console.WriteLine("\nQual coluna você deseja ver? ");
int coluna = int.Parse(Console.ReadLine());
for (int i = 0; i < N; i++) {
    Console.WriteLine(Matriz[i, coluna] + " ");
}

Console.WriteLine("Diagonal principal: ");
for (int i = 0; i < N; i++) {
    Console.Write(Matriz[i, i] + " ");
}

Console.WriteLine("\nMatriz alterada: ");
for (int i = 0; i < N; i++) {
    for (int j = 0; j < N; j++) {
        if (Matriz[i, j] < 0) {
            Console.Write(Math.Pow(Matriz[i, j],2.0) + " ");
        } else {
            Console.Write(Matriz[i, j] + " ");
        }
    }
    Console.WriteLine();
}