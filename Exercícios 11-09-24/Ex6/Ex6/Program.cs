/*
    Faça um programa que faça 5 perguntas para uma pessoa sobre um crime.
    As perguntas são:
    • "Telefonou para a vítima?"
    • "Esteve no local do crime?"
    • "Mora perto da vítima?"
    • "Devia para a vítima?"
    • "Já trabalhou com a vítima?"
    O programa deve no final emitir uma classificação sobre a participação da
    pessoa no crime. Se a pessoa responder positivamente a 2 questões ela deve
    ser classificada como "Suspeita", entre 3 e 4 como "Cúmplice" e 5 como
    “Culpado“. Caso contrário, ele será classificado como "Inocente“.
    Entrada
    As perguntas acima mencionadas

    Saída
    Deverá ser exibido na tela “Suspeita” , “Cúmplice” ou “Culpado“.
*/
String[] p = new String[5] {" ", " ", " ", " ", " "};
Console.Write("Investigaremos seu caso... Mas primeiro responda essas perguntas: \nVocê telefonou para a vítima? ");
p[0] = Console.ReadLine();
Console.Write("Esteve no local do crime? ");
p[1] = Console.ReadLine();
Console.Write("Mora perto da vítima? ");
p[2] = Console.ReadLine();
Console.Write("Devia para a vítima? ");
p[3] = Console.ReadLine();
Console.Write("Já trabalhou com a vítima? ");
p[4] = Console.ReadLine();

int total = 0;
for (int i = 0; i < 5; i++)
{
    if (p[i] == "sim" || p[i] == "s") {total++;};
}

if (total < 2) {
    Console.WriteLine("Então você é inocente");
}
else if (total == 2)
{
    Console.WriteLine("Então você é suspeito(a)");
}
else if (total == 3 || total == 4)
{
    Console.WriteLine("Então você é cúmplice");
}
else
{
    Console.WriteLine("Você é o(a) culpado(a) então!");
}