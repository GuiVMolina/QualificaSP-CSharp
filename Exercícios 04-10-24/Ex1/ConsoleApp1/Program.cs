/*
    Faça um programa que leia N números
    reais e armazene-os em um vetor.
    Em seguida, mostrar na tela o maior
    número do vetor (supor não haver empates).
    Mostrar também a posição do maior
    elemento.dos valores.
*/
Console.Write("Quantos números serão lidos? ");
int N = int.Parse(Console.ReadLine());
double[] Vetor = new double[N];
double maior = 0;
int pos = 0;
for (int i = 0; i < N; i++) {
    Console.Write(i+1 + "º valor: ");
    Vetor[i] = double.Parse(Console.ReadLine());
    if (Vetor[i] > maior) {
        maior = Vetor[i];
        pos = i;
    }
}
Console.Write("Maior " + maior);
Console.Write("Encontrado na " + pos + "º posição");