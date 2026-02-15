using Dapper;
using Dapper.Contrib.Extensions;
using Microsoft.Data.SqlClient;

namespace ClinicaMedicaConsole.Repositorios;

public class Repositorio<T> where T : class
{
    private readonly SqlConnection _conexao;
    public Repositorio(SqlConnection connection) => _conexao = connection;
    public void Create(T model) => _conexao.Insert<T>(model);

    
}
