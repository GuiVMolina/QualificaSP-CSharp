/*
    Um comerciante deseja fazer o levantamento
    do lucro das mercadorias que ele
    comercializa. Para isto, mandou digitar
    um conjunto de N mercadorias, cada uma
    contendo nome, preço de compra e preço de
    venda das mesmas.
    Fazer um programa que leia tais dados e
    determine e escreva quantas mercadorias
    proporcionaram:
    ✓ lucro < 10%
    ✓ 10% ≤ lucro ≤ 20%
    ✓ lucro > 20%
    Determine e escreva também o valor total de
    compra e de venda de todas as mercadorias,
    assim como o lucro total.
*/
Console.Write("Nº de mercadorias: ");
int N = int.Parse(Console.ReadLine());
string[] nome = new string[N];
double[] precoCompra = new double[N], precoVenda = new double[N];
double totalCompra = 0, totalVenda = 0;
double lucroA = 0, lucroB = 0, lucroC = 0;
for (int i = 0; i < N; i++) {
    Console.Write(i+1 + "º Produto: ");
    nome[i] = Console.ReadLine();
    Console.Write("Valor de compra: ");
    precoCompra[i] = double.Parse(Console.ReadLine());
    Console.Write("Valor de venda: ");
    precoVenda[i] = double.Parse(Console.ReadLine());
    totalCompra += precoCompra[i];
    totalVenda += precoVenda[i];
    if (precoVenda[i] < precoCompra[i] * 0.1 + precoCompra[i]) {
        lucroA++;
    } else if (precoVenda[i] > precoCompra[i] * 0.2 + precoCompra[i]) {
        lucroC++;
    } else {
        lucroB++;
    }
}
double lucro = totalCompra - totalVenda;
Console.WriteLine("Lucro abaixo de 10%: " + lucroA.ToString("F2"));
Console.WriteLine("Lucro entre 10% e 20%: " + lucroB.ToString("F2"));
Console.WriteLine("Lucro acima de 20%: " + lucroC.ToString("F2"));
Console.WriteLine("Valor total da compra: " + totalCompra.ToString("F2"));
Console.WriteLine("Valor total da venda: " + totalVenda.ToString("F2"));
Console.WriteLine("Lucro total: " + lucro.ToString("F2"));