/*
    O sargento Almeida organiza seu pelotão em M filas numeradas a
    partir de 1, sendo cada fila com a mesma quantidade de soldados.
    Por exemplo, a figura abaixo mostra a organização do pelotão em 3
    filas com 8 soldados em cada uma.

    Um dos exercícios que o sargento Almeida realiza com o pelotão é o
    exercício "girar fila", que consiste em dizer o número de uma fila, de
    modo que os soldados desta fila devem se mover para a direita, e o
    último soldado da direita vai para a posição mais à esquerda. Você
    deve fazer um programa para ler a formação do pelotão e executar
    o exercício "girar fila".
    Entrada:
    A entrada consiste em um inteiro M representando o número de
    filas, um inteiro N representado a quantidade de soldados por fila, as
    M filas de soldados (cada soldado é representado por um número
    inteiro), e o número inteiro para o exercício
    "girar fila".
    Saída:
    A saída contém a formação do pelotão após a execução do exercício
    "girar fila".
*/
Console.Write("Linhas de fileiras: ");
int L = int.Parse(Console.ReadLine());
Console.Write("Colunas de fileiras: ");
int C = int.Parse(Console.ReadLine());
int[,] Matriz = new int[L, C], MatrizG = new int[L, C];

Console.WriteLine("Fileiras: ");
for (int i = 0; i < L; i++) {
    string[] vet = Console.ReadLine().Split(' ');
    for (int j = 0; j < C; j++) {
        Matriz[i, j] = int.Parse(vet[j]);
        MatrizG[i, j] = Matriz[i, j];
    }
}

Console.Write("Girar fila: ");
int fila = int.Parse(Console.ReadLine()) - 1;
int final = 0;
for (int i = 0; i < C - 1; i++) {
    MatrizG[fila, i + 1] = Matriz[fila, i];
    final++;
}
MatrizG[fila, 0] = Matriz[fila, final];

Console.WriteLine("Resultado:");
for (int i = 0; i < L; i++) {
    for (int j = 0; j < C; j++) {
        Console.Write(MatrizG[i,j] + " ");
    }
    Console.WriteLine();
}
Console.ReadKey();