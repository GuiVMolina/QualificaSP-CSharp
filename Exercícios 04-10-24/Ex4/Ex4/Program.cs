/*
    Fazer um programa para ler um vetor de
    N números reais. Em seguida, mostrar
    na tela a média aritmética de todos
    elementos.
    Depois mostrar todos os elementos do
    vetor que estejam abaixo da média.
*/
Console.Write("Define um tamanho para o Array: ");
int N = int.Parse(Console.ReadLine());
double[] Vetor = new double[N];
double media = 0;
int total = 0;
for (int i = 0; i < N; i++) {
    Console.Write(i+1 + "º valor: ");
    Vetor[i] = double.Parse(Console.ReadLine());
    media += Vetor[i];
    total++;
}
media /= total;
Console.WriteLine("Abaixo da média:");
for (int i = 0; i < N; i++ ) {
    if (Vetor[i] < media) {
        Console.WriteLine(Vetor[i]);
    }
}