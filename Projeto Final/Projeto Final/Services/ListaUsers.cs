using ProjetoFinal.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoFinal.Services {
    public class ListaUsers {
        private List<User> _items;
        private int qtd = 0;
        public ListaUsers() {
            _items = new List<User>();
        }
        public void RegistrarUser (User user) {
            user.IdUser = qtd;
            _items.Add(user);
            qtd++;
        }
        public List<User> ListarUser () {
            return _items;
        }
        public User BuscarPorId (int id) {
            return _items.FirstOrDefault(i => i.IdUser == id);
        }
        public void RemoverUser (User user) {
            _items.Remove(user);
        }
    }
}