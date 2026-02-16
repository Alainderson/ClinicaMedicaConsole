namespace ClinicaMedicaConsole.Telas.Usuarios;

public class MenuUsuarios
{
  public static void Load()
  {
       Console.WriteLine("=== Usuários ===");
       Console.WriteLine("1 - Criar usuário");
       Console.WriteLine("2 - Listar usuários");
       Console.WriteLine("3 - Alterar role");
       Console.WriteLine("4 - Remover usuário");
       Console.WriteLine("0 - Voltar");
       
       short option = short.Parse(Console.ReadLine());

       switch (option)
       {
           default: MenuPrincipal.Load(); break;
       }
  }
 
}