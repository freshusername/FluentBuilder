using System;

namespace FluentBuilder
{
    public interface IUserBuilder
    {
        User Build();

        IUserBuilder WithAddress(Action<IAddressBuilder> addressBuilder);

        IUserBuilder WithCity(string city);

        IUserBuilder WithCountry(string country);

        IUserBuilder WithEmail(string email);

        IUserBuilder WithName(string name);

        IUserBuilder WithState(string state);

        IUserBuilder WithSurname(string surname);
    }
}
