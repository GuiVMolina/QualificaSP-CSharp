/*
    Crie um programa que solicite ao usuário que
    insira uma senha. O programa deve continuar
    pedindo a senha até que o usuário insira a senha
    correta "senha123". Em seguida, exiba uma
    mensagem de boas-vindas.

    Entrada
    Entrar com a senha até que a senha seja correta

    Saída
    Deverá ser exibido na tela “Bem-vindo! A senha
    está correta.”
*/
Console.Write("Digite a senha: ");
string senha = Console.ReadLine();
do {
    Console.Write("Senha incorreta! Tente novamente... ");
    senha = Console.ReadLine();
} while (senha != "senha123");
Console.WriteLine("Bem-vindo! A senha está correta.");