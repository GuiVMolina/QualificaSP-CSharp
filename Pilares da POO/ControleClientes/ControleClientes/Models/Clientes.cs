using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleClientes.Models {
    public class Clientes {
        public string Nome { get; set; }
        public string Endereco { get; set; }
        public float Valor { get; set; }
        public float ValorImposto { get; set; }
        public float Total { get; set; }

        public virtual void PagarImposto(float v) {
            this.Valor = v;
            this.ValorImposto = this.Valor * 10 / 100;
            this.Total = this.Valor + this.ValorImposto;
        }
    }
}