using System.ComponentModel.DataAnnotations;

namespace Laurel_site.Models;

public class AmateurUser : IdentityUser
{
    [Required]
    public long FrnNum {get;set;}
    public string Callsign { get; set; } = string.Empty;
    [Required]
    public string LastName { get;set;} = string.Empty;
    [Required]
    public string FirstName { get;set;} = string.Empty;
    public string MiddleInitial { get;set;} = string.Empty;
    [Required]
    public string Address1 { get; set; } = string.Empty;
    public string Address2 { get;set;} = string.Empty;
    [Required]
    public string City { get;set;} = string.Empty;
    [Required]
    public string State { get;set;} = string.Empty;
    [Required]
    public string ZipCode { get;set;} = string.Empty;
    [Required]
    public bool Felony { get;set;}
    [Required]
    public bool ActiveApp { get;set;}
}
