using Flunt.Notifications;
using Flunt.Validations;
using Statheron.Domain.ValueObjects.Abstractions;

namespace Statheron.Domain.ValueObjects;

public class Document : ValueObject
{
    public string Value { get; }

    public Document(string value)
    {
        AddNotifications(new Contract<Notification>()
            .IsNotNullOrWhiteSpace(value, nameof(Value))
        );

        Value = value;
    }
}