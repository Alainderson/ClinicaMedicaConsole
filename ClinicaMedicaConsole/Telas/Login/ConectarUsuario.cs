using System.Security.Cryptography.Pkcs;
using ClinicaMedicaConsole.Modelos;
using ClinicaMedicaConsole.Repositorios;
using Dapper;
using Microsoft.AspNetCore.Cryptography.KeyDerivation;
using Microsoft.Data.SqlClient;

namespace ClinicaMedicaConsole.Telas.Login;

public class ConectarUsuario
{
    public static void Load()
    {
        Usuario usuarioBase;
        Usuario usuarioLogando;

        for (var i = 3; i > 0; i--)
        {
            MostrarCabecalho();
            Console.WriteLine($"Tentativas restantes: {i}");
            usuarioLogando = DadosUsuarioLogado();
            usuarioBase = DadosUsuarioBase(usuarioLogando.Email);
            if (usuarioBase != null)
            {
                if (GerenciadorSenha.ValidarSenha(usuarioLogando.SenhaHash, usuarioBase.SenhaHash))
                {
                    Console.WriteLine("Usuário autenticado com sucesso! Clique para ir para o menu principal.");
                    Console.ReadLine();
                    MenuPrincipal.Load();
                    return;
                }
            }
        }

        Console.WriteLine("Tentativas zeradas, clique em qualquer tecla para voltar para o menu principal.");
        Console.ReadLine();
        MenuLogin.Load();
        return;
    }

    private static Usuario DadosUsuarioBase(string email)
    {
        var query = "SELECT TOP 1 FROM [Usuarios] WHERE Email = @email";
        SqlConnection conexao = AcessoBanco.Conexao;
        Usuario usuarioBasel = conexao.Query<Usuario>(query, new { email = email }).FirstOrDefault();
        return usuarioBasel;
    }

    private static Usuario DadosUsuarioLogado()
    {
        Console.WriteLine("Digite seu email:");
        var email = Console.ReadLine();
        Console.WriteLine("Digite seu senha:");
        var senhaHash = Console.ReadLine();
        Usuario user = new Usuario()
        {
            Email = email,
            SenhaHash = senhaHash
        };
        return user;
    }


    public static void MostrarCabecalho()
    {
        Console.Clear();
        Console.WriteLine("==============================");
        Console.WriteLine("             LOGIN            ");
        Console.WriteLine("==============================");
        Console.WriteLine();
    }
}