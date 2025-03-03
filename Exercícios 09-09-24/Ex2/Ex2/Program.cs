using System.Globalization;
double a, b, c, x1, x2, delta;

String[] vet = Console.ReadLine().Split(" ");
a = double.Parse(vet[0], CultureInfo.InvariantCulture);
b = double.Parse(vet[1], CultureInfo.InvariantCulture);
c = double.Parse(vet[2], CultureInfo.InvariantCulture);

delta = Math.Pow(b, 2.0) - 4 * a * c;

 if (delta >= 0) {
    x1 = (-b + Math.Sqrt(delta)) / 2 * a;
    x2 = (-b - Math.Sqrt(delta)) / 2 * a;
    Console.WriteLine("O valor do x¹ é: " + x1.ToString("F5", CultureInfo.InvariantCulture) +
                       "\nO valor do x² é: " + x2.ToString("F5", CultureInfo.InvariantCulture));
}

else {
    Console.WriteLine("Delta negativo, impossivel calculcar");
}