/*
    Tem-se um conjunto de dados contendo
    a altura e o sexo (M, F) de N pessoas.
    Fazer um programa que calcule e escreva:
    ✓ a maior e a menor altura do grupo
    ✓ a média de altura das mulheres
    ✓ o número de homens
*/
Console.Write("Número de pessoas: ");
int N = int.Parse(Console.ReadLine());
string[] Sexo = new string[N];
double[] Altura = new double[N];
int qntH = 0, qntM = 0, j = 1;
double maiorAltura = 0, menorAltura = 0, media = 0;
for (int i = 0; i < N; i++) {
    Console.Write("Sexo da " + j + "º pessoa: ");
    Sexo[i] = Console.ReadLine();
    Console.Write("Altura da " + j + "º pessoa: ");
    Altura[i] = double.Parse(Console.ReadLine());
}
for (int i = 0; i < N; i++) {
    if (Altura[i] > maiorAltura) {
        maiorAltura = Altura[i];
    } else if (Altura[i] < menorAltura) {
        menorAltura = Altura[i];
    } if (Sexo[i] == "F" || Sexo[i] == "f") {
        media += Altura[i];
        qntM++;
    } else {
        qntH++;
    }
}
media /= qntM;
Console.WriteLine("Menor altura: " + menorAltura);
Console.WriteLine("Maior altura: " + maiorAltura);
Console.WriteLine("Média da altura das mulheres: " + media);
Console.WriteLine("Número de homens: " + qntH);