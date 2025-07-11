using Microsoft.Data.SqlClient;
using Newtonsoft.Json;
using Dapper;
public static class BD
{
 private static string _connectionString = @"Server=localhost;
    DataBase=BD;Integrated Security =True;TrustServerCertificate=True;";
public static List<Integrante> selectIntegrante()
{
    List<Integrante> integrantes = new List<Integrante>();
    using(SqlConnection connection = new SqlConnection(_connectionString))
    {
        string query = "SELECT * FROM Integrante";
        integrantes = connection.Query<Integrante>(query).ToList();
    }
    return integrantes;
}
public static Integrante selectNombre()
{
    Integrante integrante1 = null;
    using(SqlConnection connection = new SqlConnection(_connectionString))
    {
        string query = "SELECT * FROM Integrante WHERE id = 1";
        integrante1 = connection.QueryFirstOrDefault<Integrante>(query);
    }
    return integrante1;
}
public static Integrante validarIntegrante(string email, string contraseña)
{
    Integrante integrante = null;
    using(SqlConnection connection = new SqlConnection(_connectionString))
    {
        string query = "SELECT * FROM Integrante WHERE password = @pContraseña AND email = @pEmail";
        integrante = connection.QueryFirstOrDefault<Integrante>(query, new {pEmail = email, pContraseña = contraseña});
    }
    return integrante;
}
}