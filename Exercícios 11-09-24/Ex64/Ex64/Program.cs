/*
    Leia 6 valores. Em seguida, mostre quantos destes valores
    digitados foram positivos. Na próxima linha, deve-se mostrar a
    média de todos os valores positivos digitados, com um dígito
    após o ponto decimal.

    Entrada
    A entrada contém 6 números que podem ser valores inteiros
    ou de ponto flutuante. Pelo menos um destes números será
    positivo.

    Saída
    O primeiro valor de saída é a quantidade de valores positivos. A
    próxima linha deve mostrar a média dos valores positivos
    digitados.
*/
int pos = 0, neg = 0, zero = 0, i, n;
double media = 0, x;
Console.WriteLine("Digite 6 valores e veremos quantos são negativos e quantos são positivos" +
    "\nTambém calcularemos a média de todos os valores positivos digitados");

for (i = 0; i < 6; i++)
{
    n = i + 1;
    Console.Write("Qual será o " + n + "º valor? ");
    x = int.Parse(Console.ReadLine());
    if (x > 0) {
        media = media + x;
        pos++;
    }
    else if (x < 0) { neg++; }
    else { zero++; }
}

if (pos == 0)
{
    Console.WriteLine("Não houve valores positivos...");
    if (zero == 0)
    {
        Console.Write("Todos os valores são negativos");
    }
    else
    {
        Console.WriteLine("\nHá entre esse valores:" +
            "\n" + neg + " número(s) negativo(s)" +
            "\nO zero apareceu " + zero + " vez(es)");
    }
}
else
{
    media = media / pos;
    if (zero == 0)
    {
        Console.WriteLine("\nHá entre esse valores:" +
        "\n" + pos + " número(s) positivo(s)" +
        "\n" + neg + " número(s) negativo(s)" +
        "\nA média entre os valores positivos é " + media);
    }
    else
    {
        Console.WriteLine("\nHá entre esse valores:" +
            "\n" + pos + " número(s) positivo(s)" +
            "\n" + neg + " número(s) negativo(s)" +
            "\nO zero apareceu " + zero + " vez(es)" +
            "\nA média entre os valores positivos é " + media);
    }
}