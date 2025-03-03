/*
    Faça um algoritmo para ler um valor A e um
    valor N. Imprimir a soma de A + i para cada i
    com os valores (0 <= i <= N-1). Enquanto N
    for negativo ou ZERO, um novo N(apenas N)
    deve ser lido.

    Entrada
    A entrada contém somente valores inteiros,
    podendo ser positivos ou negativos. Todos os
    valores estão na mesma linha.

    Saída
    A saída contém apenas um valor inteiro.
*/
Console.Write("Defina os valores: ");
string[] nums = Console.ReadLine().Split();
int[] N = new int[50];
N[0] = Convert.ToInt32(nums[0]);
N[1] = Convert.ToInt32(nums[1]);
int i = 1;
while (N[i] <= 0){
    i++;
    Console.Write("Qual o próximo valor de N? ");
    N[i] = int.Parse(Console.ReadLine());
}
N[0] += i + N[1] + 1;
Console.WriteLine(N[0]);