using Flunt.Notifications;

namespace Statheron.Domain.Entities.Abstractions;

public abstract class BaseEntity : Notifiable<Notification>
{
    public Guid Id { get; } = Guid.NewGuid();
    public DateTime CreatedAt { get; private set; }
    public DateTime UpdatedAt { get; private set; }

    public void SetCreated()
    {
        CreatedAt = DateTime.Now;
    }
    
    public void SetUpdated()
    {
        UpdatedAt = DateTime.Now;
    }
}