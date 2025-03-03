int L, C;
int[,] A;

L = int.Parse(Console.ReadLine());
C = int.Parse(Console.ReadLine());
A = new int[L, C];

for (int i = 0; i < L; i++) {
    string[] vet = Console.ReadLine().Split(' ');
    for (int j = 0; j < C; j++) {
        A[i, j] = int.Parse(vet[j]);
    }
}
Console.WriteLine();
for (int i = 0; i < L; i++) {
    for (int j = 0; j < C; j++) {
        Console.Write(A[i, j] + " ");
    }
    Console.WriteLine();
}
Console.ReadLine();