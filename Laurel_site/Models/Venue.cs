using System.ComponentModel.DataAnnotations.Schema;

namespace Laurel_site.Models;

public class Venue
{
    [Key]
    public int VenueId { get; set; }

    public int? LarcVenueId { get; set; }

    [ForeignKey(nameof(Team))]
    public int? TeamId { get; set; }
    public Team? Team { get; set; }

    //[MaxLength(255)]
    //[Column("Location Name")]
    public string Name { get; set; } = string.Empty;

    [MaxLength(255)]
    public string Address { get; set; } = string.Empty;

    [MaxLength(255)]
    public string City { get; set; } = string.Empty;

    [MaxLength(2)]
    public string State { get; set; } = string.Empty;

    [MaxLength(10)]
    [Column("Zip Code")]
    public string ZipCode { get; set; } = string.Empty;

    //[Column("Pre-registration Required")]
    public bool PreRegistanRequired { get; set; }

    //[Column("Pre-registration Preferred")]
    public bool PreRegistanPreferred { get; set; }

    [Column("Walk-ins Accepted")]
    public bool Walkins { get; set; }

    [MaxLength(1024)]
    [Column("Public Notes")]
    public string Notes { get; set; } = string.Empty;

    public bool Hidden { get; set; }

    public double? Latitude { get; set; }

    public double? Longitude { get; set; }

    [MaxLength(255)]
    public string Timezone { get; set; } = string.Empty;

    public bool Publish { get; set; }

    public bool Generic { get; set; }

    public DateTime? LastUpdated { get; set; }

    public DateTime? WhenAdded { get; set; }

    //[ForeignKey(nameof(VE))]
    public int? UpdatedById { get; set; }
    //public VE UpdatedBy { get; set; }
}
