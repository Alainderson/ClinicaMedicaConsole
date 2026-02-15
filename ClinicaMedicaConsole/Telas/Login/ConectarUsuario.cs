using ClinicaMedicaConsole.Modelos;
using ClinicaMedicaConsole.Repositorios;
using Dapper;
using Microsoft.AspNetCore.Cryptography.KeyDerivation;

namespace ClinicaMedicaConsole.Telas.Login;

public class ConectarUsuario
{
    public static void Load()
    {
        Console.WriteLine("Entre para acessar as funcionalidades do sistema:");
        Console.WriteLine("Informe seu email");
        string email =  Console.ReadLine();
        Usuario usuario = Credenciais(email);
        ConectarFinal(usuario);
        Console.WriteLine("Usuário logado com sucesso");
    }
    
    //retorna um objeto usuario utilizando o metodo buscarusuarioporemail
    public static Usuario Credenciais(string email)
    {
        var usuario = BuscarUsuarioPorEmail(email);
        
        while (true)
        {
            if(usuario == null)
            {
                Console.Clear();
                Console.WriteLine("Este email não existe em nosso sistema, insira um email válido.");
                Console.WriteLine();
                Console.WriteLine("Informe seu email");
                email = Console.ReadLine();
                usuario = BuscarUsuarioPorEmail(email);
            } else
            {
                return usuario;
            }
            
        }
       
    }
    //Buscar na base algum registro com o email informado
    public static Usuario BuscarUsuarioPorEmail(string email)
    {
        string consulta = "SELECT * FROM Usuarios WHERE [email] = @email"; 
        Usuario usuario = AcessoBanco.Conexao.QuerySingleOrDefault<Usuario>(consulta, new { email });
        return  usuario;
    }

    //Da match de senha informada com senha da base
    public static void ConectarFinal( Usuario usuario)
    { 
        Console.WriteLine("Informe a senha:");
        string senhaInformada = Console.ReadLine();
        
        
        while (!GerenciadorSenha.ValidarSenha(senhaInformada,usuario.SenhaHash))
        {
            Console.WriteLine("Senha incorreta, tente novamente");
            Console.WriteLine("Informe sua senha:");
            senhaInformada = Console.ReadLine();
        }
    }
    
}