

using System.ComponentModel.DataAnnotations.Schema;

namespace Laurel_site.Models;
public enum SessionStatus
{
    Deleted,
    Cancelled,
    Scheduled,
    RCReview,
    Archived
}
public class Session
{
    public int SessionId { get; set; }

    public int? LarcSessionId { get; set; }

    public int? VenueId { get; set; }
    public Venue Venue { get; set; }

    public DateTime? Datetime { get; set; }

    //[ForeignKey(nameof(VE))]
    public int? SessionManagerId { get; set; }
    //public VE SessionManager { get; set; }

    public string Note { get; set; }

    public bool Publish { get; set; }

    public bool Cancelled { get; set; }

    [MaxLength(20)]
    [Required]
    public SessionStatus SessionStatus { get; set; } = SessionStatus.Scheduled;

    public DateTime? LastUpdated { get; set; }

    public DateTime? WhenAdded { get; set; }

    //[ForeignKey(nameof(VE))]
    public int? UpdatedById { get; set; }
    //public VE UpdatedBy { get; set; }

    //[ForeignKey(nameof(VE))]
    public int? SessionVesId { get; set; }
    //public VE SessionVes { get; set; }

    public bool Reviewed { get; set; }

    public bool Archived { get; set; }

    public bool EbfAllowed { get; set; }

    [Column("Delete")]
    public bool Deleted { get; set; }
}
