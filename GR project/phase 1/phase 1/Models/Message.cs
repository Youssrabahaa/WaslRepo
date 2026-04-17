using Microsoft.EntityFrameworkCore;
// ...
using System.ComponentModel.DataAnnotations;

namespace phase_1.Models;

[Index(nameof(ConversationId), nameof(CreatedAt))]
public class Message
{
    [Key]
    public int Id { get; set; }

    [Required]
    public int ConversationId { get; set; }

    [Required]
    public int SenderUserId { get; set; }

    [Required, MaxLength(4000)]
    public string Body { get; set; } = default!;

    [Required]
    public int Type { get; set; } = 1;

    [Required]
    public DateTime CreatedAt { get; set; } = DateTime.UtcNow;

    [Required]
    public bool IsDeleted { get; set; }

    public Conversation Conversation { get; set; } = default!;

    public User SenderUser { get; set; } = default!;
}
