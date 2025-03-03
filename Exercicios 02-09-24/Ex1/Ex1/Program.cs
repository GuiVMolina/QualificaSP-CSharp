1.
/*
    Leia 2 valores inteiros e armazene-os nas variáveis a
    e b. Efetue a soma de a e b atribuindo o seu
    resultado na variável x. Imprima X conforme
    exemplo apresentado ao lado. Não apresente
    mensagem alguma além daquilo que está sendo
    especificado e não esqueça de imprimir o fim de
    linha após o resultado.

    Entrada
    A entrada contém 2 valores inteiros.

    Saída
    Imprima a mensagem "X = " (letra X maiúscula)
    seguido pelo valor da variável X e pelo final de
    linha. Cuide para que tenha um espaço antes e
    depois do sinal de igualdade,
*/
Console.WriteLine("Qual será o primeiro valor? ");
int a = int.Parse(Console.ReadLine());

Console.WriteLine("Qual será o segundo valor? ");
int b = int.Parse(Console.ReadLine());

int x = a + b;
Console.WriteLine("X = " + x);