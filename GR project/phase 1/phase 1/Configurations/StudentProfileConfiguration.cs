using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using phase_1.Models;

namespace phase_1.Configurations;

public class StudentProfileConfiguration : IEntityTypeConfiguration<StudentProfile>
{
    public void Configure(EntityTypeBuilder<StudentProfile> builder)
    {
        // Property configurations are defined by data annotations on the model.

        builder
            .HasOne(x => x.User)
            .WithOne(x => x.StudentProfile)
            .HasForeignKey<StudentProfile>(x => x.UserId)
            .OnDelete(DeleteBehavior.Cascade);

        builder
            .HasIndex(x => x.IsVerified);
    }
}
