using System.ComponentModel.DataAnnotations.Schema;

namespace DockerDotnetMySQL.Model
{
    [Table("passwords")]
    public record PasswordModel(Guid id, string platform, string password);
}
