/*
    Fazer um programa para ler um
    conjunto de N nomes de alunos, bem
    como as notas que eles tiraram no 1o e 2o
    semestres.
    Cada uma dessas informações deve ser
    armazenada em um vetor.
    Depois, imprimir os nomes dos alunos
    aprovados,
    considerando aprovado aqueles cuja
    média das notas seja maior ou igual a
    seis.
*/
Console.Write("Quantos alunos são? ");
int N = int.Parse(Console.ReadLine());
string[] Alunos = new string[N];
double[] Nota = new double[N];
int A, B, j = 1;
for (int i = 0; i < N; i++) {
    Console.Write("Nome do " + j + "º aluno: ");
    Alunos[i] = Console.ReadLine();
    Console.Write("Quanto esse aluno tirou no 1º semestre? ");
    A = int.Parse(Console.ReadLine());
    Console.Write("Quanto esse aluno tirou no 2º semestre? ");
    B = int.Parse(Console.ReadLine());
    Nota[i] = (A + B) / 2;
    j++;
}
Console.WriteLine("Alunos aprovados: ");
for (int i = 0; i < N; i++) {
    if (Nota[i] >= 6) {
        Console.WriteLine(Alunos[i]);
    }
}