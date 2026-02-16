namespace ClinicaMedicaConsole.Telas.Prescricoes;

public class MenuPrescricoes
{
    public static void Load()
    {
        Console.WriteLine("=== Prescrições ===");
        Console.WriteLine("1 - Adicionar prescrição");
        Console.WriteLine("2 - Listar prescrições por paciente");
        Console.WriteLine("3 - Histórico de prescrições");
        Console.WriteLine("0 - Voltar");
        
        short option = short.Parse(Console.ReadLine());

        switch (option)
        {
            default: MenuPrincipal.Load(); break;
        }
    }
}