using MediatR;
using Portal.Application.Common;
using Portal.DataAccess.Users.Contracts;
using Portal.Domain.Users;

namespace Portal.Application.Users.Register;

public class UserRegisterCammandHandler : IRequestHandler<UserRegisterCammnad, BaseResult<int>>
{
    private readonly IUserRepository _userRepository;

    public UserRegisterCammandHandler(IUserRepository userRepository)
    {
        _userRepository = userRepository;
    }

    public async Task<BaseResult<int>> Handle(UserRegisterCammnad request, CancellationToken cancellationToken)
    {
        try
        {
            var newUser = new User(request.User.UserName, request.User.Password, request.User.Country);

            await _userRepository.Add(newUser);

            return BaseResult<int>.BuildSuccess(newUser.Id);
        }
        catch (Exception ex)
        {

            return BaseResult<int>.BuildFailure(ex);
        }
    }
}
