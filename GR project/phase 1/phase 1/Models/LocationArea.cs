using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;

namespace phase_1.Models;

[Index(nameof(Governorate), nameof(City), nameof(Area), IsUnique = true)]
public class LocationArea
{
    [Key]
    public int Id { get; set; }

    [Required, MaxLength(100)]
    public string Governorate { get; set; } = default!;

    [Required, MaxLength(100)]
    public string City { get; set; } = default!;

    [Required, MaxLength(100)]
    public string Area { get; set; } = default!;

    public List<Case> Cases { get; set; } = new List<Case>();
}