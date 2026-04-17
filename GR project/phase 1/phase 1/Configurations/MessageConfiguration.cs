using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using phase_1.Models;

namespace phase_1.Configurations;

public class MessageConfiguration : IEntityTypeConfiguration<Message>
{
    public void Configure(EntityTypeBuilder<Message> builder)
    {
        // Property constraints are defined on the model via annotations.

        builder
            .HasOne(x => x.Conversation)
            .WithMany(x => x.Messages)
            .HasForeignKey(x => x.ConversationId)
            .OnDelete(DeleteBehavior.Cascade);

        builder
            .HasOne(x => x.SenderUser)
            .WithMany(x => x.MessagesSent)
            .HasForeignKey(x => x.SenderUserId)
            .OnDelete(DeleteBehavior.Restrict);
    }
}
