using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace phase_1.Models;

[Index(nameof(Status), nameof(AreaId), nameof(ServiceTypeId), nameof(CreatedAt))]
public class Case
{
    [Key]
    public int Id { get; set; }

    [Required]
    public int PatientUserId { get; set; }

    [Required]
    public int ServiceTypeId { get; set; }

    [Required]
    public int TreatmentCategoryId { get; set; }

    [Required]
    public int AreaId { get; set; }

    [Required, MaxLength(120)]
    public string Title { get; set; } = default!;

    [Required, MaxLength(2000)]
    public string Description { get; set; } = default!;

    [Required]
    public int Urgency { get; set; } = 2;

    [Required]
    public int Status { get; set; } = 1;

    [Column(TypeName = "decimal(10,2)")]
    public decimal? EstimatedPriceMin { get; set; }

    [Column(TypeName = "decimal(10,2)")]
    public decimal? EstimatedPriceMax { get; set; }

    [Required]
    public bool NeedsSupervisorApproval { get; set; }

    [Required]
    public DateTime CreatedAt { get; set; } = DateTime.UtcNow;

    public DateTime? ClosedAt { get; set; }

    public User PatientUser { get; set; } = default!;

    public ServiceType ServiceType { get; set; } = default!;

    public TreatmentCategory TreatmentCategory { get; set; } = default!;

    public LocationArea Area { get; set; } = default!;

    public List<Offer> Offers { get; set; }
    public List<Match> Matches { get; set; }
}
