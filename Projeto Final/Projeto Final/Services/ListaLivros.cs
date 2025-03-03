using ProjetoFinal.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoFinal.Services {
    public class ListaLivros {
        private List<Livros> _items;
        private int qtd = 0;
        public ListaLivros() {
            _items = new List<Livros>();
        }
        public void RegistrarLivro (Livros livro) {
            livro.IdLivro = qtd;
            _items.Add(livro);
            qtd++;
        }
        public List<Livros> ListarLivros () {
            return _items;
        }
        public Livros BuscarPorId (int id) {
            return _items.FirstOrDefault(i => i.IdLivro == id);
        }
        public void RemoverLivro (Livros livro) {
            _items.Remove(livro);
        }
    }
}