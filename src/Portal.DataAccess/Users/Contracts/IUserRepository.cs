using Portal.Domain.Users;

namespace Portal.DataAccess.Users.Contracts;

public interface IUserRepository 
{
    Task<int> Add(User user);
    Task Save();
}
