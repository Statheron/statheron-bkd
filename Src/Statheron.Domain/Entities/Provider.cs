using Flunt.Validations;
using Statheron.Domain.Entities.Abstractions;
using Statheron.Domain.ValueObjects;

namespace Statheron.Domain.Entities;

public class Provider : BaseEntity
{
    public string CompanyName { get; private set; }
    public string? FantasyName { get; private set; }
    public Document Document { get; private set; }
    public Address Address { get; private set; }
    public Contact Contact { get; private set; }
    public ICollection<Product> Products { get; private set; }
    
    public Provider(
        string companyName,
        string? fantasyName,
        Document document,
        Address address,
        Contact contact,
        List<Product> products)
    {
        AddNotifications(new Contract<Contact>()
            .IsNotNull(companyName, nameof(CompanyName)));

        CompanyName = companyName;
        FantasyName = fantasyName;
        Document = document;
        Address = address;
        Contact = contact;
        Products = products;
    }
}