using Dapper;
using DockerDotnetMySQL.Infra;
using DockerDotnetMySQL.Model;
using static DockerDotnetMySQL.Data.Context;

var builder  = WebApplication.CreateBuilder(args);

InfraPersistence.Setup(builder);

var app = builder.Build();

app.MapGet("/api/password", async (GetConnection conn) =>
{
    var dbConn = await conn();

    return dbConn.Query<PasswordModel>("select * from passwords");
});

app.Run();

