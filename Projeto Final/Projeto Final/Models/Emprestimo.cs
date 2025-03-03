public class Emprestimos {
    public int IdEmprestimo { get; set; }
    public int IdLivro { get; set; }
    public int IdUsuario { get; set; }
    public DateTime DataEmprestimo { get; set; }
    public DateTime? DataDevolucao { get; set; }

    public void ListarEmprestimo() {
        Console.WriteLine($"ID Empréstimo: {IdEmprestimo} | ID Livro: {IdLivro} | ID Usuário: {IdUsuario} | " +
                          $"Data Empréstimo: {DataEmprestimo.ToShortDateString()} | " +
                          $"Data Devolução: {(DataDevolucao.HasValue ? DataDevolucao.Value.ToShortDateString() : "Ainda não devolvido")}");
    }
}