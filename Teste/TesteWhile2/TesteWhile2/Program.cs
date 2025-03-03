int x, soma = 0;
x = int.Parse(Console.ReadLine());
while (x != 0) {
    soma += x;
    x = int.Parse(Console.ReadLine());
}
Console.WriteLine(soma);
Console.ReadKey();