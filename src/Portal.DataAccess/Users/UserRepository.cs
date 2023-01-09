using Portal.DataAccess.Users.Contracts;
using Portal.Domain.Users;

namespace Portal.DataAccess.Users;

public class UserRepository : IUserRepository
{
    private readonly DatabaseContext _context;

    public UserRepository(DatabaseContext context)
    {
        _context = context;
    }

    public async Task<int> Add(User user)
    {
        await _context.Users.AddAsync(user);
        return user.Id;
    }

    public async Task Save()
    {
         await  _context.SaveChangesAsync();
    }
}
