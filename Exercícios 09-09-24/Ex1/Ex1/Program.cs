Console.WriteLine("Qual foi a nota do primeiro semestre?");
double nota1 = double.Parse(Console.ReadLine());

Console.WriteLine("Qual foi a nota do segundo semestre?");
double nota2 = double.Parse(Console.ReadLine());

double soma = nota1 + nota2;
Console.WriteLine("Nota final: " + soma);

if (soma >= 60.0) {
    Console.WriteLine("Você passou de ano :)");
}

else {
    Console.WriteLine("Você reprovou de ano :(");
}