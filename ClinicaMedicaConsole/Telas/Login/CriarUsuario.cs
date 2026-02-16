using ClinicaMedicaConsole.Modelos;
using ClinicaMedicaConsole.Repositorios;
using System.Security.Cryptography;
using System.Text;
using Microsoft.AspNetCore.Cryptography.KeyDerivation;


namespace ClinicaMedicaConsole.Telas.Login;

public class CriarUsuario
{
    public static void Load()
    {
        Console.Clear();
        Console.WriteLine("Opção selecionada: Criar usuário");
        Console.WriteLine("---------------------------------");
        Console.WriteLine();
        Console.Write("Digite o nome: ");
        string nome = Console.ReadLine();
        Console.Write("Digite o email: ");
        string email = Console.ReadLine();
        string senha = GerenciadorSenha.GerarHash(CriaSenha(nome, email));

        Usuario usuario = new Usuario() { Nome = nome, Email = email, SenhaHash = senha };

        Criar(usuario);
    }

    public static string CriaSenha(string nome, string email)
    {
        while (true)
        {
            Console.WriteLine("Digite a senha: ");
            string senha = Console.ReadLine();
            Console.WriteLine("Repita a senha");
            string senhaCheck = Console.ReadLine();
            if (senha != senhaCheck && senha.Length > 0)
            {
                Console.Clear();
                Console.WriteLine($"Nome: {nome}");
                Console.WriteLine($"Email: {email}");
                Console.WriteLine();
                Console.WriteLine("Senha incorreta, tente novamente");
            }
            else
            {
                Console.Clear();
                Console.WriteLine($"Nome: {nome}");
                Console.WriteLine($"Email: {email}");
                Console.WriteLine("Senha Correta");
                return senha;
            }
        }
    }

    public static void Criar(Usuario usuario)
    {
        var repositorio = new Repositorio<Usuario>(AcessoBanco.Conexao);
        repositorio.Create(usuario);
    }
}