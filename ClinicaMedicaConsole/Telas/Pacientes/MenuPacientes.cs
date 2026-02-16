namespace ClinicaMedicaConsole.Telas.Pacientes;

public class MenuPacientes
{
    public static void Load()
    {
        Console.WriteLine("");
        Console.WriteLine("=== Pacientes ===");
        Console.WriteLine("1 - Cadastrar paciente");
        Console.WriteLine("2 - Listar pacientes");
        Console.WriteLine("3 - Buscar paciente por CPF");
        Console.WriteLine("4 - Editar paciente");
        Console.WriteLine("5 - Remover paciente");
        Console.WriteLine("0 - Voltar");

        short option = short.Parse(Console.ReadLine());

        switch (option)
        {
            default: MenuPrincipal.Load(); break;
        }
    }
}