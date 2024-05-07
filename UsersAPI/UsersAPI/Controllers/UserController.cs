
using Microsoft.AspNetCore.Mvc;

namespace UsersAPI.Controllers
{
    [ApiController]
    [Route("[Controller]")]

    public class UserController : ControllerBase
    {
        [HttpPost]
        public IActionResult CadastraUsuario()
        {
            throw new NotImplementedException();
        }
    }
}
