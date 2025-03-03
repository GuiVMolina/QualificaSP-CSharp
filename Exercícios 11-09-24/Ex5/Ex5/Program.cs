/*
    Faça um programa que verifique se uma letra
    digitada é vogal ou consoante

    Entrada
    a,b,c,d,e,f,g,h ...

    Saída
    Deverá ser exibido na tela “A letra é uma vogal!” ou
    “A letra é uma consoante!”.
*/
Console.Write("Digite uma letra e verificaremos se ela é vogal ou consoante: ");
string letra = Console.ReadLine();

if (letra == "a" || letra == "e" || letra == "i" || letra == "o"|| letra == "u")
{
    Console.WriteLine("É uma vogal");
}
else
{
    Console.WriteLine("É uma consoante");
}