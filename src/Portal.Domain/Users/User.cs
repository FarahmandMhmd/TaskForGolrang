namespace Portal.Domain.Users;

public class User
{
    public User(string userName, string password, string country)
    {
        UserName = userName;
        Password = password;
        Country = country;
    }
    public int Id { get; set; }
    public string UserName { get; private set; } = string.Empty;
    public string Password { get; private set; } = string.Empty;
    public string Country { get; private set; } = string.Empty;

}
