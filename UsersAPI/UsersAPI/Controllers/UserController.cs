
using AutoMapper;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using UsersAPI.Data.Dtos;
using UsersAPI.Models;

namespace UsersAPI.Controllers
{
    [ApiController]
    [Route("[Controller]")]

    public class UserController : ControllerBase
    {
        private IMapper _mapper;
        private UserManager<Usuario> _userManager;

        public UserController(IMapper mapper, UserManager<Usuario> userManager)
        {
            _mapper = mapper;
            _userManager = userManager;
        }
        [HttpPost]
        public async Task<IActionResult> CadastraUsuario(CreateUsuarioDto dto)
        {
            Usuario usuario = _mapper.Map<Usuario>(dto);
            IdentityResult resultado = await _userManager.CreateAsync(usuario, dto.Password);

            if (resultado.Succeeded) return Ok("Usuário cadastrado com sucesso");
            throw new ApplicationException("Falha ao cadastra usuário.");
        }
    }
}
