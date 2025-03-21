      namespace PriceNegotiationApp.Entities
{
    public class User
    {
        public int Id { get; set; }
        public string? FullName { get; set; }
        public bool IsLogIn { get; set; }
        public UserType Type { get; set; }
    }

    public enum UserType
    {
        Client,
        Employee
    }
}
