/*
    Faça um programa que leia N números
    inteiros e armazene-os em um vetor.
    Em seguida, mostre na tela:
    - todos os números pares
    - a quantidade de números pares
*/
Console.Write("Quantos números serão lidos? ");
int N = int.Parse(Console.ReadLine());
int[] Vetor = new int[N];
int[] Pares = new int[N];
int par = 0;
for (int i = 0; i < N; i++) {
    Console.Write(i+1 + "º valor: ");
    Vetor[i] = int.Parse(Console.ReadLine());
    if (Vetor[i] % 2 == 0) {
        Pares[par] = Vetor[i];
        par++;
    }
}
Console.WriteLine("{0}", string.Join(", ", Pares));
Console.Write("Quantidades de números pares: " + par);