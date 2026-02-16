using System.Security.Cryptography.Pkcs;
using ClinicaMedicaConsole.Modelos;
using ClinicaMedicaConsole.Repositorios;
using Dapper;
using Microsoft.AspNetCore.Cryptography.KeyDerivation;
using Microsoft.Data.SqlClient;

namespace ClinicaMedicaConsole.Telas.Login;

public class ConectarUsuario
{
    public string _email { get; set; }
    public string _senhaHash { get; set; }
    public static void Load()
    {
        Usuario usuarioBase = new Usuario();
        Usuario usuarioLogando = new Usuario();
     
        for(var i = 3; i>0;i--)
        {
            MostrarCabecalho();
            Console.WriteLine($"Tentativas restantes: {i}");
            usuarioLogando = DadosUsuarioLogado();
            usuarioBase = DadosUsuarioBase(usuarioLogando.Email);
            if(usuarioBase != null)
            {
                if(GerenciadorSenha.ValidarSenha(usuarioLogando.SenhaHash, usuarioBase.SenhaHash))
                {
                    Console.WriteLine("Usuário autenticado com sucesso! Clique para ir para o menu principal.");
                    Console.ReadLine();
                    MenuPrincipal.Load();
                    break;
                }
            }

        }
        Console.WriteLine("Tentativas zeradas, clique em qualquer tecla para voltar para o menu principal.");
        Console.ReadLine();
        MenuLogin.Load();
        
      

    }

    private static Usuario DadosUsuarioBase(string email)
    {
        var query = "SELECT * FROM [Usuarios] WHERE Email = @email" ;
        SqlConnection conexao = AcessoBanco.Conexao;
        Usuario usuarioBasel = conexao.Query<Usuario>(query, new { email = email}).FirstOrDefault();
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