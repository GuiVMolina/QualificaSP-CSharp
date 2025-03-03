/*
    Faça um programa para ler dois vetores
    A e B, contendo N elementos cada. Em
    seguida, gere um terceiro vetor C onde
    cada elemento de C é a soma dos
    elementos correspondentes de A e B.
    Imprima o vetor C gerado.
*/
Console.Write("Qual o tamanho dos vetores A e B? ");
int N = int.Parse(Console.ReadLine());
int[] A = new int[N], B = new int[N], C = new int[N];
for (int i = 0; i < N; i++) {
    Console.Write(i+1 + "º valor de A: ");
    A[i] = int.Parse(Console.ReadLine());
    Console.Write(i+1 + "º valor de B: ");
    B[i] = int.Parse(Console.ReadLine());
    C[i] = A[i] + B[i];
}
Console.WriteLine("Soma dos valores: ");
Console.WriteLine("{0}", string.Join(", ", C));