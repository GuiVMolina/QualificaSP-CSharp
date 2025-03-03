using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Invertário.Models {
    public class Produto : Item {
        public int Quantidade { get; set; }
        public static Produto CriarProduto(){
            Produto produto = new Produto();

            Console.Write("Insira o nome: ");
            produto.Nome = Console.ReadLine();

            Console.Write("Insira o preço: ");
            produto.Preco = double.Parse(Console.ReadLine());

            Console.Write("Insira a quantidade: ");
            produto.Quantidade = int.Parse(Console.ReadLine());

            return produto;
        }
        public override void Atualizar() {
            Console.Write("Insira o novo nome: ");
            Nome = Console.ReadLine();

            Console.Write("Insira o novo preço: ");
            Preco = double.Parse(Console.ReadLine());

            Console.Write("Insira a nova quantidade: ");
            Quantidade = int.Parse(Console.ReadLine());
        }
        public override void MostrarDetalhes() {
            Console.WriteLine($"ID: {Id}\nProduto: {Nome}\nPreço: {Preco:C}\nQuantidade: {Quantidade}");
        }
    }
}