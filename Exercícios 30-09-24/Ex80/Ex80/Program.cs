/*
    Leia 100 valores inteiros. Apresente então o
    maior valor lido e a posição dentre os 100
    valores lidos.

    Entrada
    O arquivo de entrada contém 100 números
    inteiros, positivos e distintos.

    Saída
    Apresente o maior valor lido e a posição de
    entrada, conforme exemplo ao lado.
*/
int maior = 0, menor = 0;
int[] Num = new int[100];
for (int i = 0; i <= Num.Length; i++) {
    Console.Write(i+1 + "º Valor: ");
    Num[i] = int.Parse(Console.ReadLine());
    if (Num[i] > maior) {
        maior = Num[i];
    } else if (Num[i] < menor) {
        menor = Num[i];
    }
}
Console.WriteLine("Maior: " + maior);
Console.WriteLine("Menor: " + menor);