using Invertário.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Invertário.Services {
    public class InventarioService {
        private List<Item> _items;
        private int qtd = 0;
        public InventarioService() {
            _items = new List<Item>();
        }
        public void AdicionarItem (Item item) {
            item.Id = qtd;
            _items.Add(item);
            qtd++;
        }
        public List<Item> ListarItems () {
            return _items;
        }
        public Item BuscarPorId (int id) {
            return _items.FirstOrDefault(i => i.Id == id);
        }
        public void RemoverItem (Item item) {
            _items.Remove(item);
        }
    }
}