/*
    Ler um inteiro N e uma matriz quadrada
    de ordem N. Mostrar qual o maior
    elemento de cada linha. Suponha não
    haver empates.

    Entrada:
    A entrada contém o número N, depois os
    dados da matriz.

    Saída:
    A saída contém os números
    representando o maior elemento
*/
Console.Write("Valor de N: ");
int N = int.Parse(Console.ReadLine());
int[] maior = new int[N];
int[,] Matriz = new int[N, N];
maior[0] = 0;

for (int i = 0; i < N; i++) {
    string[] vet = Console.ReadLine().Split(' ');
    for (int j = 0; j < N; j++) {
        Matriz[i, j] = int.Parse(vet[j]);
    }
}
Console.WriteLine("Maiores valores:");
for (int i = 0; i < N; i++) {
    for (int j = 0; j < N; j++) {
        if (maior[i] < Matriz[i,j]) {
            maior[i] = Matriz[i,j];
        }
    }
    Console.WriteLine(maior[i]);
}