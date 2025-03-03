using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoFinal.Models {
    public class Livros {
        public string Titulo { get; set; }
        public string Autor { get; set; }
        public int Ano { get; set; }
        public int IdLivro { get; set; }
        public bool Disponivel { get; set; } = true;
        public static Livros RegistrarLivro() {
            Livros livro = new Livros();

            Console.Write("Insira o título: ");
            livro.Titulo = Console.ReadLine();

            Console.Write("Insira o autor: ");
            livro.Autor = Console.ReadLine();

            Console.Write("Insira o ano: ");
            livro.Ano = int.Parse(Console.ReadLine());

            return livro;
        }
        public void AtualizarLivros() {
            Console.Write("Insira o novo título: ");
            Titulo = Console.ReadLine();

            Console.Write("Insira o novo autor: ");
            Autor = Console.ReadLine();

            Console.Write("Insira o novo ano: ");
            Ano = int.Parse(Console.ReadLine());
        }
        public void EmprestarLivro() {
            if (Disponivel) {
                Disponivel = false;
                Console.WriteLine("Livro pego emprestado com sucesso!");
            } else {
                Console.WriteLine("Livro já emprestado!");
            }
        }
        public void DevolverLivro() {
            if (!Disponivel) {
                Disponivel = true;
                Console.WriteLine("Livro devolvido com sucesso!");
            } else {
                Console.WriteLine("Livro já está disponível");
            }
        }
        public void ListarLivros() {
            Console.WriteLine($"ID: {IdLivro}\tLivro: {Titulo}\nAutor: {Autor}\tAno: {Ano}\nDisponível: {(Disponivel ? "Sim" : "Não")}");
            Console.WriteLine();
        }
    }
}