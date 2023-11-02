namespace PrototypePattern.Entities;

public class Address : ICloneable<Address>
{
    public Guid Id { get; set; }
    public string Street { get; set; } = "";
    public string City { get; set; } = "";

    public Address(string street, string city)
    {
        Id = Guid.NewGuid();
        Street = street;
        City = city;
    }

    public Address Clone()
    {
        return new Address(Street, City);
    }

    public override string ToString()
    {
        return $"Id: {Id}, Street: {Street}, City: {City}";
    }
}

public class Customer : ICloneable<Customer>
{
    public Guid Id { get; set; }
    public string Name { get; set; } = "";
    public string DocumentNumber { get; set; } = "";
    public string Email { get; set; } = "";
    public Address Address { get; set; } = null!;

    public Customer(string name, string documentNumber, string email, Address address)
    {
        /* With this functionality we can copy all PRIVATE and PROTECTED members */
        Id = Guid.NewGuid();
        Name = name;
        DocumentNumber = documentNumber;
        Email = email;
        Address = address;
    }

    public Customer Clone()
    {
        return new Customer(Name, DocumentNumber, Email, Address.Clone());
    }

    public Customer ShallowClone()
    {
        return new Customer(Name, DocumentNumber, Email, Address);
    }

    public override string ToString()
    {
        return $"Id: {Id}, Name: {Name}, DocumentNumber: {DocumentNumber}, Email: {Email}, Address: {Address.ToString()}";
    }
}