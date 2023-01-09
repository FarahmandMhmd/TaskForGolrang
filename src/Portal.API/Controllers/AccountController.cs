using MediatR;
using Microsoft.AspNetCore.Mvc;
using Portal.Application.Users.Register;

namespace Portal.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AccountController : ControllerBase
    {
        private readonly IMediator _mediator;

        public AccountController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpPost]
        public async Task<IActionResult> Register(RegisterUserDto user)
        {
            return Ok(await _mediator.Send(new UserRegisterCammnad { User = user }));
        }
    }
}
