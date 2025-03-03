/*
    Leia 1 valor inteiro N, que representa o número de
    casos de teste que se segue. Cada caso de teste
    consiste em 3 valores reais, cada um deles com
    uma casa decimal. Apresente a média ponderada
    para cada um destes conjuntos de 3 valores, sendo
    que o primeiro valor tem peso 2, o segundo valor
    tem peso 3 e o terceiro valor tem peso 5.

    Entrada
    O arquivo de entrada contém um valor inteiro N na
    primeira linha. Cada N linha a seguir contém um
    caso de teste com três valores com uma casa
    decimal cada valor.

    Saída
    Para cada caso de teste, imprima a média
    ponderada dos 3 valores, conforme exemplo ao
    lado.
*/
double n1, n2, n3, media;
Console.Write("Número de testes: ");
int N = int.Parse(Console.ReadLine());
for (int i = 0; i < N; i++) {
    n1 = double.Parse(Console.ReadLine());
    n2 = double.Parse(Console.ReadLine());
    n3 = double.Parse(Console.ReadLine());
    media = ((n1 * 2.0) + (n2 * 3.0) + (n3 * 5.0)) / 10.0;
    Console.WriteLine(media.ToString("F5"));
}