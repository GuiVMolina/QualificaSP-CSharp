using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Invertário.Models {
    public abstract class Item {
        public int Id { get; set; }
        public string Nome { get; set; }
        public double Preco { get; set; }

        public abstract void MostrarDetalhes();
        public abstract void Atualizar();
    }
}