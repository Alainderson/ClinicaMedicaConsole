namespace ClinicaMedicaConsole.Telas.Medicos;

public class MenuMedicos
{
    public static void Load()
    {
        Console.WriteLine("=== Médicos ===");
        Console.WriteLine("1 - Cadastrar médico");
        Console.WriteLine("2 - Listar médicos");
        Console.WriteLine("3 - Buscar médico por especialidade");
        Console.WriteLine("4 - Editar médico");
        Console.WriteLine("5 - Remover médico");
        Console.WriteLine("0 - Voltar");

        short option = short.Parse(Console.ReadLine());

        switch (option)
        {
            default: MenuPrincipal.Load(); break;
        }
    }
}