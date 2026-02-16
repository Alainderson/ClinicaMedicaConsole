using System.ComponentModel.DataAnnotations.Schema;

namespace ClinicaMedicaConsole.Modelos;

[Table("[Usuarios]")]
public class Usuario
{
    
    public int Id { get; set; }
    public string Nome { get; set; }
    public string Email { get; set; }
    public string SenhaHash { get; set; }
    
}