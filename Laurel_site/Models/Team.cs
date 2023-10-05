using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel;
using System.Drawing;

namespace Laurel_site.Models;

public class Team
{
    [Key]
    public int Id { get; set; }

    [Required]
    public string Name { get; set; } = string.Empty;

    [Required]
    public string Code { get; set; } = string.Empty;

    //[ForeignKey(nameof(Region))]
    //[Column("RegionId")]
    //public int RegionId { get; set; }
    //public Region Region { get; set; }

    [Column("Website District")]
    public int? District { get; set; }

    //[ForeignKey(nameof(VE))]
    //[Column("LeaderId")]
    public int LeaderId { get; set; }
    //public VE Leader { get; set; }

    //[Column("Primary City")]
    //[MaxLength(20)]
    public string City { get; set; } = string.Empty;

    //[Column("Primary State")]
    //[MaxLength(2)]
    public string State { get; set; } = string.Empty;

    //[Column("Public Email")]
    //[MaxLength(50)]
    public string Email { get; set; } = string.Empty;

    //[Column("Public Phone")]
    //[MaxLength(20)]
    public string Phone { get; set; } = string.Empty;

    //[Column("Web Site")]
    //[MaxLength(255)]
    public string Website { get; set; } = string.Empty;

    [DefaultValue(true)]
    public bool Active { get; set; }



}
