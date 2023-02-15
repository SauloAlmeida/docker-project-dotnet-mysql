using Dapper;
using DockerDotnetMySQL.DTO;
using DockerDotnetMySQL.Infra;
using DockerDotnetMySQL.Model;
using Microsoft.AspNetCore.Mvc;
using static DockerDotnetMySQL.Data.Context;

var builder  = WebApplication.CreateBuilder(args);

InfraPersistence.Setup(builder);

var app = builder.Build();

app.MapGet("/api/password", async (GetConnection conn) =>
{
    var dbConn = await conn();

    return dbConn.Query<PasswordModel>("select * from passwords");
});

app.MapPost("/api/password", async (GetConnection conn, [FromBody] PasswordInput input) =>
{
    var dbConn = await conn();

    await dbConn.ExecuteAsync($"INSERT INTO passwords VALUES(@id, @platform, @password)", new { id = Guid.NewGuid(), input.platform, input.password });

    return Results.NoContent();
});


app.Run();

