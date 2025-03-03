/*
    Leia um valor inteiro. A seguir, calcule o menor
    número de notas possíveis (cédulas) no qual o valor
    pode ser decomposto. As notas consideradas são
    de 100, 50, 20, 10, 5, 2 e 1. A seguir mostre o valor lido
    e a relação de notas necessárias.

    Entrada
    O arquivo de entrada contém um valor inteiro N
    (0 < N < 1000000).

    Saída
    Imprima o valor lido e, em seguida, a quantidade
    mínima de notas de cada tipo necessárias,
    conforme o exemplo fornecido. Não esqueça de
    imprimir o fim de linha após cada linha.
*/
Console.Write("Qual a quantia de dinheiro que você possui? ");
int notas = int.Parse(Console.ReadLine());
int atual = notas;
int notas100 = atual / 100;
atual = atual - notas100 * 100;
int notas50 = atual / 50;
atual = atual - notas50 * 50;
int notas20 = atual / 20;
atual = atual - notas20 * 20;
int notas10 = atual / 10;
atual = atual - notas10 * 10;
int notas5 = atual / 5;
atual = atual - notas5 * 5;
int notas2 = atual / 2;
atual = atual - notas2 * 2;
int notas1 = atual;
Console.WriteLine(notas + "\n" + notas100 + " nota(s) de R$ 100,00\n" + notas50 + " nota(s) de R$ 50,00\n" + notas20 + " nota(s) de R$ 20,00\n" + notas10 + " nota(s) de R$ 10,00\n" + notas5 + " nota(s) de R$ 5,00\n" + notas2 + " nota(s) de R$ 2,00\n" + notas1 + " nota(s) de R$ 1,00");

/*
    ALTERNATIVA:
    int nota = int.Parse(Console.ReadLine());   >> lê o valor da nota
    int quociente = resto / nota;               >> calcula quantas notas há (ex. 576/100 passa a ser 5)
    int resto %= nota;                          >> calcula o resto da divisão pela nota (ex. 576/100 passa a ser 76)
*/