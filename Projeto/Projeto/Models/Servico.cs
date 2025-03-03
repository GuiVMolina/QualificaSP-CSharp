using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Invertário.Models {
    public class Servico : Item {
        public int DuracaoEmHoras { get; set; }
        public static Servico CriarServico()
        {
            Servico servico = new Servico();

            Console.Write("Insira o nome: ");
            servico.Nome = Console.ReadLine();

            Console.Write("Insira o preço: ");
            servico.Preco = double.Parse(Console.ReadLine());

            Console.Write("Insira a duração: ");
            servico.DuracaoEmHoras = int.Parse(Console.ReadLine());

            return servico;
        }
        public override void Atualizar()
        {
            Console.Write("Insira o novo nome: ");
            Nome = Console.ReadLine();

            Console.Write("Insira o novo preço: ");
            Preco = double.Parse(Console.ReadLine());

            Console.Write("Insira a nova duração: ");
            DuracaoEmHoras = int.Parse(Console.ReadLine());
        }
        public override void MostrarDetalhes()
        {
            Console.WriteLine($"ID: {Id}\nServico: {Nome}\nPreço: {Preco:C}\nQuantidade: {DuracaoEmHoras}");
        }
    }
}