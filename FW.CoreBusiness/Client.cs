using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace FW.CoreBusiness;

public class Client
{
    public int Id { get; set; }
    public string FirstName { get; set; } = string.Empty;
    public string LastName { get; set; } = string.Empty;
    public string EmailAddress { get; set; } = string.Empty;
    public string PhoneNumber { get; set; } = string.Empty;

    public string FullName => $"{FirstName} {LastName}";

    public DateTime Created { get; set; }
    public DateTime? Updated { get; set; }

    public string CreatedBy { get; set; } = string.Empty;
    public string? UpdatedBy { get; set; }

    [ForeignKey("CreatedBy"), JsonIgnore]
    public IdentityUser IdentityUser { get; set; } = null!;

    [JsonIgnore]
    public virtual ICollection<Vehicle>? Vehicles { get; set; }

    public Client()
    {
        
    }
}

