using System.ComponentModel.DataAnnotations.Schema;

namespace DockerDotnetMySQL.Model
{
    [Table("passwords")]
    public record PasswordModel(string id, string platform, string password);
}
