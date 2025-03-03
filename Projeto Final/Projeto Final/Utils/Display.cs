using ProjetoFinal.Services;
using ProjetoFinal.Models;
using System;
using System.Collections.Generic;

namespace ProjetoFinal.Utils {
    public static class Display {
        public static void MostrarInventario(ListaLivros listaLivros) {
            var livros = listaLivros.ListarLivros();
            foreach (var livro in livros) {
                livro.ListarLivros();
            }
        }
        public static void MostrarInventario(ListaUsers listaUsers) {
            var users = listaUsers.ListarUser();
            foreach (var user in users) {
                user.ListarUsers();
            }
        }
        public static void MostrarEmprestimos(ListaEmprestimos listaEmprestimos) {
            var emprestimos = listaEmprestimos.ListarEmprestimos();
            foreach (var emprestimo in emprestimos) {
                emprestimo.ListarEmprestimo();
            }
        }
    }
}