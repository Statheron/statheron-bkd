using Flunt.Notifications;
using Flunt.Validations;
using Statheron.Domain.ValueObjects.Abstractions;

namespace Statheron.Domain.ValueObjects;

public class Contact : ValueObject
{
    public string Email { get; private set; }
    public string? Phone { get; private set; }
    public string? WebSite { get; private set; }

    public Contact(string email, string phone, string webSite)
    {
        AddNotifications(new Contract<Notification>()
            .IsNotNull(email, nameof(Email))
            .IsNotEmail(email, nameof(Email)));

        Email = email;
        Phone = phone;
        WebSite = webSite;
    }
}