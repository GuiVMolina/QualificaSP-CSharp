2.
/*
    A fórmula para calcular a área de uma circunferência é:
    area = π . raio2.
    Considerando para este problema que π = 3.14159:
    - Efetue o cálculo da área, elevando o valor de raio
    ao quadrado e multiplicando por π.

    Entrada
    A entrada contém um valor de ponto flutuante
    (dupla precisão), no caso, a variável raio.

    Saída
    Apresentar a mensagem "A=" seguido pelo valor da
    variável area, conforme exemplo ao lado, com 4
    casas após o ponto decimal. Utilize variáveis de dupla
    precisão (double). Como todos os problemas, não
    esqueça de imprimir o fim de linha após o resultado.
*/
const double PI = 3.14159;

Console.WriteLine("Qual o valor do raio da circunferência? ");
double raio = double.Parse(Console.ReadLine());

double area = PI * raio * raio;
Console.WriteLine("A área da circunfêrencia é aproximadamente " + area.ToString("F4");