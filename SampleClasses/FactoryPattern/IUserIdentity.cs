namespace SampleClasses.FactoryPattern
{
    public interface IUserIdentity
    {
    }

    public class IdentityCard: IUserIdentity
    {
        public string SSN { get; set; }
    }

    public class MacAddress : IUserIdentity
    {
        public string RawAddress { get; set; }
    }

}