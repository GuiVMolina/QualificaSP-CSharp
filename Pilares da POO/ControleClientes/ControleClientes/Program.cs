using ControleClientes.Models;

float valPag;

Console.Write("Informe o nome: ");
string nome = Console.ReadLine();

Console.Write("Informe o endereço: ");
string endereco = Console.ReadLine();

Console.Write("Pessoa Física(f) ou pessoa Jurídica(j)? ");
string tipo = Console.ReadLine();

switch (tipo) {
    case "f":
        PessoaFisica pf = new PessoaFisica();
        pf.Nome = nome;
        pf.Endereco = endereco;

        Console.Write("Informe o CPF: ");
        pf.Cpf = Console.ReadLine();
        Console.Write("Informe o RG: ");
        pf.Rg = Console.ReadLine();
        Console.Write("Informe o valor da compra: ");
        valPag = float.Parse(Console.ReadLine());

        pf.PagarImposto(valPag);
        Console.Write("-------- Pessoa Física --------");
        Console.WriteLine("\nNome...........: " + pf.Nome);
        Console.WriteLine("Endereço.......: " + pf.Endereco);
        Console.WriteLine("CPF............: " + pf.Cpf);
        Console.WriteLine("RG.............: " + pf.Rg);
        Console.WriteLine("Valor da Compra: " + pf.Valor.ToString("C"));
        Console.WriteLine("Imposto........: " + pf.ValorImposto.ToString("C"));
        Console.WriteLine("Total..........: " + pf.Total.ToString("C"));
        break;

    case "j":
        PessoaJuridica pj = new PessoaJuridica();
        pj.Nome = nome;
        pj.Endereco = endereco;

        Console.Write("Informe o CNPJ: ");
        pj.Cnpj = Console.ReadLine();
        Console.Write("Informe o IE: ");
        pj.Ie = Console.ReadLine();
        Console.Write("Informe o valor da compra: ");
        valPag = float.Parse(Console.ReadLine());

        pj.PagarImposto(valPag);
        Console.Write("-------- Pessoa Jurídica --------");
        Console.WriteLine("\nNome...........: " + pj.Nome);
        Console.WriteLine("Endereço.......: " + pj.Endereco);
        Console.WriteLine("CNPJ...........: " + pj.Cnpj);
        Console.WriteLine("IE.............: " + pj.Ie);
        Console.WriteLine("Valor da Compra: " + pj.Valor.ToString("C"));
        Console.WriteLine("Imposto........: " + pj.ValorImposto.ToString("C"));
        Console.WriteLine("Total..........: " + pj.Total.ToString("C"));
        break;

    default:
        Console.WriteLine("Entrada inválida");
        break;
}