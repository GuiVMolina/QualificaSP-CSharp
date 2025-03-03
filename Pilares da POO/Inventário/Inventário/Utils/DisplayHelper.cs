using Invertário.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Invertário.Utils {
    public static class DisplayHelper {
        public static void MostrarInventario(InventarioService inventarioService) {
            var itens = inventarioService.ListarItems();
            foreach (var item in itens) {
                item.MostrarDetalhes();
            }
        }
    }
}