using MySqlConnector;
using static DockerDotnetMySQL.Data.Context;

namespace DockerDotnetMySQL.Infra
{
    public static class InfraPersistence
    {
        public static void Setup(WebApplicationBuilder builder)
        {
            builder.Services.AddScoped<GetConnection>(sp =>
                async () =>
                {
                    try
                    {
                        string connectionString = sp.GetService<IConfiguration>()["ConnectionString"];
                        var connection = new MySqlConnection(connectionString);
                        await connection.OpenAsync();
                        return connection;
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                        return null;
                    }
                });
        }
    }
}
