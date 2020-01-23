# FluentBuilder

Fluent Builder Pattern.

## Program

 ```csharp
public static class Program
{
    public static void Main()
    {
        IAddressBuilder addressBuilder = new AddressBuilder();
        IUserBuilder userBuilder = new UserBuilder(addressBuilder);

        var user = userBuilder
            .WithName("Name")
            .WithSurname("Surname")
            .WithEmail("email@mail.com")
            .WithCity("City")
            .WithState("State")
            .WithCountry("Country")
            .Build();

        Console.WriteLine($"Name: {user.Name}");
        Console.WriteLine($"Surname: {user.Surname}");
        Console.WriteLine($"Email: {user.Email}");
        Console.WriteLine($"City: {user.Address.City}");
        Console.WriteLine($"State: {user.Address.State}");
        Console.WriteLine($"Country: {user.Address.Country}");

        Console.ReadKey();
    }
}
 ```

## Address
 ```csharp
public class Address
{
    public string City { get; set; }

    public string Country { get; set; }

    public string State { get; set; }
}
 ```

## User
 ```csharp
public class User
{
    public Address Address { get; set; }

    public string Email { get; set; }

    public string Name { get; set; }

    public string Surname { get; set; }
}
 ```

## IAddressBuilder

 ```csharp
public interface IAddressBuilder
{
    Address Build();

    IAddressBuilder WithCity(string city);

    IAddressBuilder WithCountry(string country);

    IAddressBuilder WithState(string state);
}
 ```

## AddressBuilder

 ```csharp
public class AddressBuilder : IAddressBuilder
{
    private Address Address { get; } = new Address();

    public Address Build()
    {
        return Address;
    }

    public IAddressBuilder WithCity(string city)
    {
        Address.City = city;
        return this;
    }

    public IAddressBuilder WithCountry(string country)
    {
        Address.Country = country;
        return this;
    }

    public IAddressBuilder WithState(string state)
    {
        Address.State = state;
        return this;
    }
}
 ```

## IUserBuilder

 ```csharp
public interface IUserBuilder
{
    User Build();

    IUserBuilder WithCity(string city);

    IUserBuilder WithCountry(string country);

    IUserBuilder WithEmail(string email);

    IUserBuilder WithName(string name);

    IUserBuilder WithState(string state);

    IUserBuilder WithSurname(string surname);
}
 ```

## UserBuilder

 ```csharp
public class UserBuilder : IUserBuilder
{
    public UserBuilder(IAddressBuilder addressBuilder)
    {
        AddressBuilder = addressBuilder;
    }

    private IAddressBuilder AddressBuilder { get; }

    private User User { get; } = new User();

    public User Build()
    {
        User.Address = AddressBuilder.Build();
        return User;
    }

    public IUserBuilder WithCity(string city)
    {
        AddressBuilder.WithCity(city);
        return this;
    }

    public IUserBuilder WithCountry(string country)
    {
        AddressBuilder.WithCountry(country);
        return this;
    }

    public IUserBuilder WithEmail(string email)
    {
        User.Email = email;
        return this;
    }

    public IUserBuilder WithName(string name)
    {
        User.Name = name;
        return this;
    }

    public IUserBuilder WithState(string state)
    {
        AddressBuilder.WithState(state);
        return this;
    }

    public IUserBuilder WithSurname(string surname)
    {
        User.Surname = surname;
        return this;
    }
}
 ```
