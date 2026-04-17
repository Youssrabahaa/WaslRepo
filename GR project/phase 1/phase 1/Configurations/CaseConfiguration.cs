using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using phase_1.Models;

namespace phase_1.Configurations;

public class CaseConfiguration : IEntityTypeConfiguration<Case>
{
    public void Configure(EntityTypeBuilder<Case> builder)
    {
        // Property constraints are defined in the model via data annotations.

        builder
            .HasOne(x => x.PatientUser)
            .WithMany(x => x.CasesPosted)
            .HasForeignKey(x => x.PatientUserId)
            .OnDelete(DeleteBehavior.Restrict);

        builder
            .HasOne(x => x.ServiceType)
            .WithMany(x => x.Cases)
            .HasForeignKey(x => x.ServiceTypeId)
            .OnDelete(DeleteBehavior.Restrict);

        builder
            .HasOne(x => x.TreatmentCategory)
            .WithMany(x => x.Cases)
            .HasForeignKey(x => x.TreatmentCategoryId)
            .OnDelete(DeleteBehavior.Restrict);

        builder
            .HasOne(x => x.Area)
            .WithMany(x => x.Cases)
            .HasForeignKey(x => x.AreaId)
            .OnDelete(DeleteBehavior.Restrict);

        builder
            .HasIndex(x => new { x.PatientUserId, x.Status, x.CreatedAt });
    }
}
