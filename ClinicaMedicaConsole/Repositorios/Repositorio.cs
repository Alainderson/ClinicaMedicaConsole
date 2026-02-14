using Dapper.Contrib.Extensions;
using Microsoft.Data.SqlClient;

namespace ClinicaMedicaConsole.Repositorios;

public class Repositorio<T> where T : class
{
    private readonly SqlConnection _connection;
    public Repositorio(SqlConnection connection) => _connection = connection;
    public void Create(T model) => _connection.Insert<T>(model);
    /*Testando */
}
