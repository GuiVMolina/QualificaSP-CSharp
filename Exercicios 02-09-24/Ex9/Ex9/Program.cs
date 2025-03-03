/*
    Calcule o consumo médio de um automóvel sendo
    fornecidos a distância total percorrida (em Km) e o
    total de combustível gasto (em litros).

    Entrada
    O arquivo de entrada contém dois valores: um valor
    inteiro X representando a distância total percorrida
    (em Km), e um valor real Y representando o total de
    combustível gasto, com um dígito após o ponto
    decimal.

    Saída
    Apresente o valor que representa o consumo
    médio do automóvel com 3 casas após a vírgula,
    seguido da mensagem "km/l".
*/
Console.WriteLine("Qual a distância total percorrida do carro? ");
int x = int.Parse(Console.ReadLine());

Console.WriteLine("Qual o total de combustível gasto? ");
double y = int.Parse(Console.ReadLine());

double consumo = x / y;
Console.WriteLine("Esse carro consome em média " + consumo.ToString("F3") + "Km/L");