/*
    Crie um programa que solicite ao usuário uma
    palavra e verifique se a palavra é um palíndromo
    (ou seja, lê-se da mesma forma da esquerda para a
    direita e da direita para a esquerda).

    Entrada
    Palavras palíndromos e não palíndromos.

    Saída
    Deverá ser exibido na tela “A palavra é ou não
    palíndromo”
*/
Console.Write("Digite sua palavra: ");
string palavra = Console.ReadLine().ToLower();
char[] caractere = palavra.ToCharArray();
int j = 0, i = caractere.Length - 1;
bool palindromo = true;
while (caractere.Length > j){
    if (caractere[i] != caractere[j]){
        palindromo = false;
    }
    i--; j++;
}
if (palindromo == true){
    Console.WriteLine("A palavra é um palíndromo");
} else {
    Console.WriteLine("A palavra não é um palíndromo");
}