/*
    Crie um programa que gere um número aleatório
    entre 1 e 100 e, em seguida, permita ao usuário
    adivinhar o número. O programa deve informar se
    o número inserido é maior ou menor que o
    número gerado até que o usuário adivinhe
    corretamente.

    Entrada
    Entrar com um número de 1 a 100

    Saída
    Deverá ser exibido na tela “Parabéns! Você
    adivinhou o número em 3 tentativas.”
*/
Random rnd = new Random();
int randNum = rnd.Next(1, 100);
Console.WriteLine("Adivinhe o número entre 1 e 100 (" + randNum + ")");
Console.Write("Qual será o seu número? ");
int num = int.Parse(Console.ReadLine());
int i = 0;
do {
    if (num < randNum) {
        Console.Write("Tente um número maior... ");
    } else {
        Console.Write("Tente um número menor... ");
    }
    num = int.Parse(Console.ReadLine());
    i++;
} while (num != randNum);
Console.WriteLine("Parabéns! Você adivinhou o número em " + i + " tentativas");