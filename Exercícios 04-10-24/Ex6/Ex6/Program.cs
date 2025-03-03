/*
    Fazer um programa para ler um
    conjunto de nomes de pessoas e suas
    respectivas idades. Depois, mostrar na
    tela o nome da pessoa mais velha.
*/
Console.Write("Quantas pessoas são? ");
int N = int.Parse(Console.ReadLine());
string[] Pessoa = new string[N];
int[] Idade = new int[N];
int maisVelho = 0;
string maiorIdade = "";
for (int i = 0; i < N; i++) {
    Console.Write("Nome do " + i+1 + "º cidadão: ");
    Pessoa[i] = Console.ReadLine();
    Console.Write("Quantos anos ele tem? ");
    Idade[i] = int.Parse(Console.ReadLine());
    if (Idade[i] < maisVelho) {
        maiorIdade = Pessoa[i];
    }
}
Console.WriteLine("Pessoa mais velha: " + maiorIdade);