using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using phase_1.Models;

namespace phase_1.Configurations;

public class ReportConfiguration : IEntityTypeConfiguration<Report>
{
    public void Configure(EntityTypeBuilder<Report> builder)
    {
        // Property constraints are declared by model attributes.

        builder
            .HasOne(x => x.ReporterUser)
            .WithMany(x => x.ReportsSubmitted)
            .HasForeignKey(x => x.ReporterUserId)
            .OnDelete(DeleteBehavior.Restrict);

        builder
            .HasOne(x => x.HandledByAdmin)
            .WithMany(x => x.ReportsHandled)
            .HasForeignKey(x => x.HandledByAdminId)
            .OnDelete(DeleteBehavior.Restrict);

        builder
            .HasIndex(x => new { x.TargetType, x.TargetId });
    }
}
