using ProjetoFinal.Services;
using ProjetoFinal.Models;
using ProjetoFinal.Utils;

ListaLivros listaLivros = new ListaLivros();
ListaUsers listaUsers = new ListaUsers();
ListaEmprestimos listaEmprestimos = new ListaEmprestimos();

bool continuar = true;

while (continuar) {
    Console.Clear();
    Console.WriteLine("--------------- Biblioteca ---------------");
    Console.WriteLine("1. Adicionar Livro .......................");
    Console.WriteLine("2. Listar Livros .........................");
    Console.WriteLine("3. Atualizar Livro .......................");
    Console.WriteLine("4. Remover Livro .........................");
    Console.WriteLine("5. Adicionar Usuário .....................");
    Console.WriteLine("6. Listar Usuários .......................");
    Console.WriteLine("7. Atualizar Usuário .....................");
    Console.WriteLine("8. Remover Usuário .......................");
    Console.WriteLine("9. Pegar livro emprestado ................");
    Console.WriteLine("10. Devolver Livro .......................");
    Console.WriteLine("11. Listar Empréstimos ...................");
    Console.WriteLine("12. Sair .................................");
    Console.WriteLine("------------------------ Escolha uma opção");
    Console.WriteLine();
    int opcao = int.Parse(Console.ReadLine());

    switch (opcao)
    {
        case 1:
            Livros livro = Livros.RegistrarLivro();
            listaLivros.RegistrarLivro(livro);
            break;
        case 2:
            Display.MostrarInventario(listaLivros);
            Console.WriteLine("Pressione qualquer tecla para voltar as opções...");
            Console.ReadKey();
            break;
        case 3:
            AtualizarLivro(listaLivros);
            break;
        case 4:
            RemoverLivro(listaLivros);
            break;

        case 5:
            User user = User.RegistrarUser();
            listaUsers.RegistrarUser(user);
            break;
        case 6:
            Display.MostrarInventario(listaUsers);
            Console.WriteLine("Pressione qualquer tecla para voltar as opções...");
            Console.ReadKey();
            break;
        case 7:
            AtualizarUser(listaUsers);
            break;
        case 8:
            RemoverUser(listaUsers);
            break;

        case 9:
            Emprestar(listaLivros, listaUsers, listaEmprestimos);
            Console.WriteLine("Pressione qualquer tecla para continuar...");
            Console.ReadKey();
            break;
        case 10:
            Devolver(listaLivros, listaEmprestimos);
            Console.WriteLine("Pressione qualquer tecla para continuar...");
            Console.ReadKey();
            break;
        case 11:
            Display.MostrarEmprestimos(listaEmprestimos);
            Console.WriteLine("Pressione qualquer tecla para voltar as opções...");
            Console.ReadKey();
            break;

        case 12:
            continuar = false;
            break;
        default:
            Console.WriteLine("Opcão inválida, tente novamente...");
            break;
    }

    if (continuar) {
        Console.WriteLine("Pressione qualquer tecla para continuar");
    }
}

void Emprestar(ListaLivros listaLivros, ListaUsers listaUsers, ListaEmprestimos listaEmprestimos) {
    Console.Write("Digite o ID do usuário: ");
    int idUsuario = int.Parse(Console.ReadLine());
    User usuario = listaUsers.BuscarPorId(idUsuario);

    if (usuario == null) {
        Console.WriteLine("Usuário não encontrado");
        return;
    }

    Console.Write("Digite o ID do livro: ");
    int idLivro = int.Parse(Console.ReadLine());
    Livros livro = listaLivros.BuscarPorId(idLivro);

    if (livro == null || !livro.Disponivel) {
        Console.WriteLine("Livro não disponível");
        return;
    }

    int limiteEmprestimos = usuario.Premium ? 10 : 5;
    var emprestimosAtivos = listaEmprestimos.ListarEmprestimos()
        .Count(e => e.IdUsuario == idUsuario && e.DataDevolucao == null);

    if (emprestimosAtivos >= limiteEmprestimos) {
        Console.WriteLine("Limite de empréstimos atingido...");
        return;
    }

    livro.EmprestarLivro();

    Emprestimos emprestimo = new Emprestimos {
        IdLivro = idLivro,
        IdUsuario = idUsuario,
        DataEmprestimo = DateTime.Now
    };
    listaEmprestimos.RegistrarEmprestimo(emprestimo);
}

void Devolver(ListaLivros listaLivros, ListaEmprestimos listaEmprestimos) {
    Console.Write("Digite o ID do empréstimo: ");
    int idEmprestimo = int.Parse(Console.ReadLine());

    Emprestimos emprestimo = listaEmprestimos.BuscarPorId(idEmprestimo);

    if (emprestimo == null || emprestimo.DataDevolucao != null) {
        Console.WriteLine("Empréstimo não encontrado ou já devolvido");
        return;
    }

    Livros livro = listaLivros.BuscarPorId(emprestimo.IdLivro);

    if (livro != null) {
        livro.DevolverLivro();
        emprestimo.DataDevolucao = DateTime.Now;
        listaEmprestimos.AtualizarEmprestimo(emprestimo);
    } else {
        Console.WriteLine("Livro associado ao empréstimo não encontrado");
    }
}

void AtualizarLivro(ListaLivros InventarioService) {
    Console.Write("Digite o ID do livro a ser atualizado: ");
    int id = int.Parse(Console.ReadLine());

    Livros livro = listaLivros.BuscarPorId(id);

    if (livro != null) {
        livro.AtualizarLivros();
    } else {
        Console.WriteLine("Livro não encontrado, tente novamente...");
    }
}
void RemoverLivro(ListaLivros InventarioService) {
    Console.Write("Digite o ID do livro a ser removido: ");
    int id = int.Parse(Console.ReadLine());

    Livros livro = listaLivros.BuscarPorId(id);

    if (livro != null) {
        listaLivros.RemoverLivro(livro);
        Console.WriteLine("Livro removido com sucesso!");
    } else {
        Console.WriteLine("Livro não encontrado, tente novamente...");
    }
}
void AtualizarUser(ListaUsers InventarioService) {
    Console.Write("Digite o ID do usuário a ser atualizado: ");
    int id = int.Parse(Console.ReadLine());

    User user = listaUsers.BuscarPorId(id);

    if (user != null) {
        user.AtualizarUser();
    } else {
        Console.WriteLine("Usuário não encontrado, tente novamente...");
    }
}
void RemoverUser(ListaUsers InventarioService) {
    Console.Write("Digite o ID do usuário a ser removido: ");
    int id = int.Parse(Console.ReadLine());

    User user = listaUsers.BuscarPorId(id);

    if (user != null) {
        listaUsers.RemoverUser(user);
        Console.WriteLine("Usuário removido com sucesso!");
    } else {
        Console.WriteLine("Usuário não encontrado, tente novamente...");
    }
}