/*
    Ler dois números M e N, e depois ler
    uma matriz MxN de números inteiros,
    conforme exemplo. Em seguida, mostrar
    na tela somente os números negativos
    da matriz.

    Entrada:
    A entrada contém os números M e N na
    mesma linha, depois os dados da matriz.

    Saída:
    A saída contém uma mensagem e
    depois os números negativos da matriz,
    conforme exemplo.
*/
Console.Write("Linhas: ");
int M = int.Parse(Console.ReadLine());
Console.Write("Colunas: ");
int N  = int.Parse(Console.ReadLine());
int[,] Matriz = new int [M,N];

for (int i = 0; i < M; i++) {
    string[] vet = Console.ReadLine().Split(' ');
    for (int j = 0; j < N; j++) {
        Matriz[i, j] = int.Parse(vet[j]);
    }
}
Console.WriteLine("Valores negativos:");
for (int i = 0; i < M; i++) {
    for (int j = 0; j < N; j++) {
        if (Matriz[i, j] < 0) {
            Console.WriteLine(Matriz[i,j]);
        }
    }
}