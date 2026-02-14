using ClinicaMedicaConsole.Modelos;

namespace ClinicaMedicaConsole.Telas.Login;


public class CriarUsuario
{
    
    public static void Load()
    {
        Object _usuario;
        
        Console.Clear();
        Console.WriteLine("Opção selecionada: Criar usuário");
        Console.WriteLine("---------------------------------");
        Console.WriteLine();
        Console.Write("Digite o nome: ");
        string nome = Console.ReadLine();
        Console.Write("Digite o email: ");
        string email = Console.ReadLine();
        string senha = criaSenha(nome, email);
        



    }
    public static string criaSenha(string nome , string email)
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
                Console.WriteLine("Senha incorreta, tente novamente");
                Console.Write($"Nome: {nome}");
                Console.Write($"Email: {email}");
            }
            else
            {   
                Console.Clear();
                Console.Write($"Nome: {nome}");
                Console.Write($"Email: {email}");
                Console.WriteLine("Senha Correta");
                return senha;
            }
        }
        
    }

    public static void Criar(Usuario usuario)
    {
        
    }
    
  
    
    
}