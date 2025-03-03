/*
    Escreva um programa que leia três valores com ponto flutuante
    de dupla precisão: A, B e C. Em seguida, calcule e mostre:
    a) a área do triângulo retângulo com A por base e C por altura.
    b) a área do círculo de raio C. (pi = 3.14159)
    c) a área do trapézio com A e B por bases e C por altura.
    d) a área do quadrado com lado B.
    e) a área do retângulo com lados A e B.

    Entrada
    O arquivo de entrada contém três valores com um dígito após o
    ponto decimal.

    Saída
    O arquivo de saída deverá conter 5 linhas de dados. Cada linha
    corresponde a uma das áreas descritas acima, sempre com
    mensagem correspondente e um espaço entre os dois pontos e o
    valor. O valor calculado deve ser apresentado com 3 dígitos após o
    ponto decimal.
*/

double A, B, C, pi;
pi = Math.PI;
A = double.Parse(Console.ReadLine());
B = double.Parse(Console.ReadLine());
C = double.Parse(Console.ReadLine());

double areaT = (A * C) / 2;
Console.WriteLine("TRIANGULO: " + areaT.ToString("F3"));

double areaC = pi * Math.Pow(C, 2);
Console.WriteLine("CIRCULO: " + areaC.ToString("F3"));

double areaTR = ((A + B) * C) / 2;
Console.WriteLine("TRAPEZIO: " + areaTR.ToString("F3"));

double areaQ = Math.Pow(B, 2);
Console.WriteLine("QUADRADO: " + areaQ.ToString("F3"));

double areaR = A * B;
Console.WriteLine("RETANGULO: " + areaR.ToString("F3"));