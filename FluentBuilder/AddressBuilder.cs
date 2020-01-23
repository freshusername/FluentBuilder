namespace FluentBuilder
{
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
}
