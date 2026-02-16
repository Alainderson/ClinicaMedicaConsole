using ClinicaMedicaConsole.Telas;
using Microsoft.Data.SqlClient;

namespace ClinicaMedicaConsole
{
    internal class Program
    {
        private const string TextoConexao =
            "Server=localhost,1433;Database=ClinicaMedica ;User Id=sa;Password=Cl1nM3d@123;TrustServerCertificate=True;";

        static void Main(string[] args)
        {
            AcessoBanco.Conexao = new SqlConnection(TextoConexao);
            using (AcessoBanco.Conexao)
            {
                MenuLogin.Load();
            }
        }
    }
}