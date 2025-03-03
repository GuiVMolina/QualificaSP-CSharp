int opcoes, operacao;
double x, y, total;
Console.WriteLine("Bem-vindo à Calculadora!");
do {
    Console.WriteLine("Qual operação você deseja realisar?");
    Console.WriteLine("Adição (1) \tSubtração (2) \tMultiplicação (3) \tDivisão (4) \tPotenciação (5) \tRaiz (6)");
    operacao = int.Parse(Console.ReadLine());
    Console.Write("Primeiro valor (X): ");
    x = double.Parse(Console.ReadLine());
    Console.Write("Segundo valor (Y): ");
    y = double.Parse(Console.ReadLine());
    while (operacao == 4 && x == 0) {
        Console.WriteLine("Impossivel calcular! (Divisão por zero, x = 0)");
        Console.Write("Defina outro valor para X: ");
        x = double.Parse(Console.ReadLine());
    }
    while (operacao == 4 && y == 0) {
        Console.WriteLine("Impossivel calcular! (Divisão por zero, y = 0)");
        Console.Write("Defina outro valor para Y: ");
        y = double.Parse(Console.ReadLine());
    }
    switch (operacao) {
        case 1:
            total = adicao(x, y);
            break;
        case 2:
            total = subtracao(x, y);
            break;
        case 3:
            total = multiplicacao(x, y);
            break;
        case 4:
            total = divisao(x, y);
            break;
        case 5:
            total = potencia(x, y);
            break;
        case 6:
            total = raiz(x, y);
            break;
        default:
            total = 0;
            break;
    }
    Console.WriteLine("Resultado: " + total);
    Console.WriteLine("Deseja executar a calculadora novamente?");
    Console.WriteLine("Sim (1) \tNão (2)");
    opcoes = int.Parse(Console.ReadLine());
    Console.Clear();
} while (opcoes == 1);
Console.WriteLine("Calculadora finalizada...");
static double adicao (double n1, double n2)
{
    var Resultado = n1 + n2;
    return Resultado;
}
static double subtracao(double n1, double n2)
{
    var Resultado = n1 - n2;
    return Resultado;
}
static double multiplicacao(double n1, double n2)
{
    var Resultado = n1 * n2;
    return Resultado;
}
static double divisao(double n1, double n2)
{
    var Resultado = n1 / n2;
    return Resultado;
}
static double potencia(double n1, double n2)
{
    var Resultado = Math.Pow(n1,n2);
    return Resultado;
}
static double raiz(double n1, double n2)
{
    var Resultado = Math.Pow(n1 , 1 / n2);
    return Resultado;
}