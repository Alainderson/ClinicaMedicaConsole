using ClinicaMedicaConsole.Telas.Login;

namespace ClinicaMedicaConsole.Telas;

public class MenuLogin
{
    public MenuLogin()
    {
        Load();
    }
    public static void Load()
    {
        MostrarCabecalho();
        MostrarOpcoes();
    }

    public static void MostrarCabecalho()
    {

        Console.Clear();
        Console.WriteLine("==============================");
        Console.WriteLine("        MENU DE LOGIN         ");
        Console.WriteLine("==============================");
        Console.WriteLine();

    }

    public static void MostrarOpcoes()
    {
        Console.WriteLine("Selecione uma opção abaixo:");
        Console.WriteLine();
        Console.WriteLine("1 -  Criar uma conta");
        Console.WriteLine("2 -  Logar com usuário e senha");
        Console.WriteLine("0 -  Sair");
        Console.WriteLine();

        short opcao = short.Parse(Console.ReadLine());

        switch (opcao)
        {
            case 1: CriarUsuario.Load();break;
            case 2: ConectarUsuario.Load();break; 
            case 0: Environment.Exit(0);break;
            default: Load();break; 
        }
    }
    
}