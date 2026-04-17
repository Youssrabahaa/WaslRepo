using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using phase_1.Models;

namespace phase_1.Configurations;

public class ConversationConfiguration : IEntityTypeConfiguration<Conversation>
{
    public void Configure(EntityTypeBuilder<Conversation> builder)
    {
        // CreatedAt handled by model attribute.

        builder
            .HasOne(x => x.Match)
            .WithOne(x => x.Conversation)
            .HasForeignKey<Conversation>(x => x.MatchId)
            .OnDelete(DeleteBehavior.Cascade);
    }
}
