using System;

namespace FluentBuilder
{
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
            return User;
        }

        public IUserBuilder WithAddress(Action<IAddressBuilder> addressBuilder)
        {
            addressBuilder(AddressBuilder);
            User.Address = AddressBuilder.Build();
            return this;
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
}
