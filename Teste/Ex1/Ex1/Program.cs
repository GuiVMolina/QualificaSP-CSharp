/*
     Uma operadora de telefonia cobra R$ 50.00 por um plano básico que
    dá direito a 100 minutos de telefone. Cada minuto que exceder a
    franquia de 100 minutos custa R$ 2.00. Fazer um programa para ler a
    quantidade de minutos que uma pessoa consumiu, e mostrar o valor a
    ser pago.
*/
Console.Write("Quantos minutos você consumiu? ");
int x = int.Parse(Console.ReadLine());
double y = 50.0;
if (x > 100) {
    x -= 100;
    y += x * 2;
}
Console.WriteLine("Valor a pagar: RS " + y.ToString("F2"));