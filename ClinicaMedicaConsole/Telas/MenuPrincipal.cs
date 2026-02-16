

using ClinicaMedicaConsole.Telas.Consultas;
using ClinicaMedicaConsole.Telas.Medicos;
using ClinicaMedicaConsole.Telas.Pacientes;
using ClinicaMedicaConsole.Telas.Prescricoes;
using ClinicaMedicaConsole.Telas.Relatorios;
using ClinicaMedicaConsole.Telas.Usuarios;

namespace ClinicaMedicaConsole.Telas;

public class MenuPrincipal
{
    public static void Load( )
    {
        Console.Clear();
        Console.WriteLine("=== Bem vindo(a) ao Projeto Clínica Médica ===");
        Console.WriteLine("Seu pefil: ");
        Console.WriteLine("1 - Pacientes");
        Console.WriteLine("2 - Médicos  ");
        Console.WriteLine("3 - Consultas  ");
        Console.WriteLine("4 - Prescrições  ");
        Console.WriteLine("5 - Usuários  ");
        Console.WriteLine("6 - Relatórios  ");
        Console.WriteLine("0 - Pacientes  ");
        
        short opcao = short.Parse(Console.ReadLine());

        switch (opcao)
        {
            case 1: MenuPacientes.Load(); break;
            case 2: MenuMedicos.Load(); break;
            case 3: MenuConsultas.Load(); break;
            case 4: MenuPrescricoes.Load(); break;
            case 5: MenuUsuarios.Load(); break;
            case 6: MenuRelatorios.Load(); break;
        }
    }
}