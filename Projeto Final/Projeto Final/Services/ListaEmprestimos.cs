using ProjetoFinal.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ProjetoFinal.Services {
    public class ListaEmprestimos {
        private List<Emprestimos> _emprestimos;
        private int _qtdEmprestimos = 0;
        public ListaEmprestimos() {
            _emprestimos = new List<Emprestimos>();
        }
        public void RegistrarEmprestimo(Emprestimos emprestimo) {
            emprestimo.IdEmprestimo = _qtdEmprestimos++;
            _emprestimos.Add(emprestimo);
        }
        public List<Emprestimos> ListarEmprestimos() {
            return _emprestimos;
        }
        public Emprestimos BuscarPorId(int id) {
            return _emprestimos.FirstOrDefault(e => e.IdEmprestimo == id);
        }
        public void AtualizarEmprestimo(Emprestimos emprestimo) {
            var existente = BuscarPorId(emprestimo.IdEmprestimo);
            if (existente != null) {
                existente.DataDevolucao = emprestimo.DataDevolucao;
            }
        }
    }
}