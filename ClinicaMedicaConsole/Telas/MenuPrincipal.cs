using System;
using ClinicaMedicaConsole.Telas.Login;

namespace ClinicaMedicaConsole.Telas;

public class MenuPrincipal
{
    public MenuPrincipal()
    {
        Load();
    }
    public static void Load()
    {
        Console.WriteLine("Menu Principal");
        Console.WriteLine();
        Console.WriteLine("Selecione uma opção abaixo:");
        Console.WriteLine();
        Console.WriteLine("1 -  Criar uma conta");
        Console.WriteLine("2 -  Logar com usuário e senha");
        Console.WriteLine("3 -  Sair");

        short opcao = short.Parse(Console.ReadLine());

        switch (opcao)
        {
            case 1: CriarUsuario.Load();break;
            case 2: Console.WriteLine("Logar uma conta");break; 
            default: Environment.Exit(0);break;
        }
    }
}