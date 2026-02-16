namespace ClinicaMedicaConsole.Telas.Consultas;

public class MenuConsultas
{
    public static void Load()
    {
        Console.WriteLine("=== Consultas ===");
        Console.WriteLine("1 - Agendar consulta");
        Console.WriteLine("2 - Listar consultas do dia");
        Console.WriteLine("3 - Listar consultas por médico");
        Console.WriteLine("4 - Cancelar consulta");
        Console.WriteLine("5 - Detalhes da consulta");
        Console.WriteLine("0 - Voltar");
        
        short option = short.Parse(Console.ReadLine());

        switch (option)
        {
            default: MenuPrincipal.Load(); break;
        }
    }
}