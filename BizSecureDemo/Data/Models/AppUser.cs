using System.ComponentModel.DataAnnotations.Schema;

namespace BizSecureDemo.Models;
public class AppUser
{
    public int Id { get; set; }
    public string Email { get; set; } = "";
    public string PasswordHash { get; set; } = "";
    [NotMapped]
    public int? FailedLogins { get; set; }
    [NotMapped]
    public DateTime? LockoutUntilUtc { get; set; }

}
