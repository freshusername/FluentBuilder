using System;

namespace FluentBuilder
{
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
}
