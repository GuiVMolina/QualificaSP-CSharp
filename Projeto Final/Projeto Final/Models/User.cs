using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoFinal.Models {
    public class User {
        public string Nome { get; set; }
        public bool Premium { get; set; }
        public int IdUser { get; set; }
        public static User RegistrarUser() {
            User user = new User();

            Console.Write("Insira o nome: ");
            user.Nome = Console.ReadLine();

            Console.Write("O usuário é Premium? (s/n): ");
            string resposta = Console.ReadLine().ToLower();
            user.Premium = resposta == "s" || resposta == "sim";

            return user;
        }
        public void AtualizarUser() {
            User user = new User();

            Console.Write("Insira o novo nome: ");
            Nome = Console.ReadLine();

            Console.Write("Esse novo usuário é Premium? ");
            string resposta = Console.ReadLine();
            if (resposta.ToLower() == "sim" || resposta.ToLower() == "s") {
                user.Premium = true;
            } else {
                user.Premium = false;
            }
        }
        public void ListarUsers() {
            Console.WriteLine($"ID: {IdUser}\tNome: {Nome}\nPremium: {(Premium ? "Sim" : "Não")}");
            Console.WriteLine();
        }
    }
}