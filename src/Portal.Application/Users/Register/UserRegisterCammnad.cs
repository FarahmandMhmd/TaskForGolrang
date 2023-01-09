using MediatR;
using Portal.Application.Common;

namespace Portal.Application.Users.Register;

public class UserRegisterCammnad : IRequest<BaseResult<int>>
{
    public RegisterUserDto User { get; set; }
}
