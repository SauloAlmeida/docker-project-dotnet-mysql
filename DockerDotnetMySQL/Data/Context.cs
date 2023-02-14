using System.Data;

namespace DockerDotnetMySQL.Data
{
    public class Context
    {
        public delegate Task<IDbConnection> GetConnection();
    }
}