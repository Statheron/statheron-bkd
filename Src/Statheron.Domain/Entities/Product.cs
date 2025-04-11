using System.Text.RegularExpressions;
using Statheron.Domain.Entities.Abstractions;

namespace Statheron.Domain.Entities;

public class Product : BaseEntity
{
    public string Name { get; private set; }
    public string Description { get; private set; }
    public decimal Price { get; private set; }
    public Group Group { get; private set; }
    public Provider Provider { get; private set; }

    public Product(string name, string description, decimal price)
    {
        Name = name;
        Description = description;
        Price = price;
    }
}