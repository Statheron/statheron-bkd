using Flunt.Notifications;
using Flunt.Validations;
using Statheron.Domain.ValueObjects.Abstractions;

namespace Statheron.Domain.ValueObjects;

public class Address : ValueObject
{
    public string Street { get; private set; }
    public string City { get; private set; }
    public string State { get; private set; }
    public string ZipCode { get; private set; }
    public string Country { get; private set; }
    public string Number { get; private set; }

    public Address(string street, string city, string state, string zipCode, string country, string number)
    {
        AddNotifications(new Contract<Notification>()
            .IsNotNullOrWhiteSpace(street, nameof(Street))
            .IsNotNullOrWhiteSpace(city, nameof(City))
            .IsNotNullOrWhiteSpace(state, nameof(State))
            .IsNotNullOrWhiteSpace(zipCode, nameof(ZipCode))
            .IsNotNullOrWhiteSpace(country, nameof(Country))
            .IsNotNullOrWhiteSpace(number, nameof(Number)));

        Street = street;
        City = city;
        State = state;
        ZipCode = zipCode;
        Country = country;
        Number = number;
    }
}