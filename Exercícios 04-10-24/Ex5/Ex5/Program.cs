/*
    Fazer um programa para ler um vetor de
    N números inteiros. Em seguida, mostrar
    na tela a média aritmética somente dos
    números pares lidos.
*/
Console.Write("Quantos valores irão ser lidos? ");
int N = int.Parse(Console.ReadLine());
int[] Vetor = new int[N];
int par = 0;
double media = 0;
for (int i = 0; i < N; i++) {
    Console.Write(i+1 + "º valor: ");
    Vetor[i] = int.Parse(Console.ReadLine());
    if (Vetor[i] % 2 == 0) {
        media += Vetor[i];
        par++;
    }
}
media /= par;
if (par != 0) {
    Console.WriteLine("Média dos valores pares: " + media);
}