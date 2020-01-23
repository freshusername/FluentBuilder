namespace FluentBuilder
{
    public interface IAddressBuilder
    {
        Address Build();

        IAddressBuilder WithCity(string city);

        IAddressBuilder WithCountry(string country);

        IAddressBuilder WithState(string state);
    }
}
