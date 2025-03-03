5.
/*
    Leia 2 valores de ponto flutuante de dupla precisão
    a e b, que correspondem a 2 notas de um aluno. A
    seguir, calcule a média do aluno, sabendo que a
    nota a tem peso 3.5 e a nota b tem peso 7.5 (A
    soma dos pesos, portanto, é 11). Assuma que cada
    nota pode ir de 0 até 10.0, sempre com uma casa
    decimal.

    Entrada
    O arquivo de entrada contém 2 valores com uma
    casa decimal cada um.

    Saída
    Imprima a mensagem "MEDIA" e a média do aluno
    conforme exemplo ao lado, com 5 dígitos após o
    ponto decimal e com um espaço em branco antes
    e depois da igualdade. Utilize variáveis de dupla
    precisão (double) e como todos os problemas, não
    esqueça de imprimir o fim de linha após o
    resultado.
*/
const double P1 = 3.5;
const double P2 = 7.5;
const double MEDIA = P1 + P2;
Console.WriteLine("Qual foi a sua primeira nota? ");
double a = double.Parse(Console.ReadLine());
a = a * P1;

Console.WriteLine("Qual foi a sua segunda nota? ");
double b = double.Parse(Console.ReadLine());
b = b * P2;

double mediaPonderada = (a + b) / MEDIA;
Console.WriteLine("MEDIA = " + mediaPonderada.ToString("F5");