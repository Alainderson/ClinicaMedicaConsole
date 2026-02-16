namespace ClinicaMedicaConsole.Telas.Relatorios;

public class MenuRelatorios
{

    public static void Load()
    {
        Console.WriteLine("=== Relatórios ===");
        Console.WriteLine("1 - Consultas do dia");
        Console.WriteLine("2 - Consultas por médico");
        Console.WriteLine("3 - Histórico de paciente");
        Console.WriteLine("4 - Estatísticas gerais");
        Console.WriteLine("0 - Voltar");
        
        short option = short.Parse(Console.ReadLine());

        switch (option)
        {
            default: MenuPrincipal.Load(); break;
        }
    }
}