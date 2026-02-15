using System;
using ClinicaMedicaConsole.Telas.Login;
using ClinicaMedicaConsole.Modelos;

namespace ClinicaMedicaConsole.Telas;

public class MenuPrincipal
{
    static void Load( Usuario usuario)
    {
        Console.WriteLine($"Usuário: {usuario.Nome}");
    }
}