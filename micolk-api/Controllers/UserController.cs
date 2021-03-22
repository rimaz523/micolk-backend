using Application.Users.Commands.CreateUser;
using Application.Users.Queries.GetUserById;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace micolk_api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class UserController : ApiControllerBase
    {

        [HttpGet]
        public async Task<ActionResult<UserDto>> GetUserById([FromQuery] GetUserByIdQuery query)
        {
            return await Mediator.Send(query);
        }

        [HttpPost]
        public async Task<ActionResult<UserDto>> Post(CreateUserCommand command)
        {
            return await Mediator.Send(command);
        }
    }
}
