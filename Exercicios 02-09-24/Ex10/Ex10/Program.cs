/*
    Dois carros (X e Y) partem em uma mesma direção.
    O carro X sai com velocidade constante de 60 Km/h
    e o carro Y sai com velocidade constante de 90 Km/h.
    Em uma hora (60 minutos) o carro Y consegue se
    distanciar 30 quilômetros do carro X, ou seja,
    consegue se afastar um quilômetro a cada 2
    minutos.
    Leia a distância (em Km) e calcule quanto tempo
    leva (em minutos) para o carro Y tomar essa
    distância do outro carro.

    Entrada
    O arquivo de entrada contém um número inteiro.

    Saída
    Imprima o tempo necessário seguido da
    mensagem "minutos".
*/
Console.WriteLine("Quantos quilômetros (Km) o carro X andou? ");
double km = int.Parse(Console.ReadLine());
km = km * 60 * 1.5;

Console.WriteLine("Então, o carro Y está " + km + " minutos na frente do carro X");