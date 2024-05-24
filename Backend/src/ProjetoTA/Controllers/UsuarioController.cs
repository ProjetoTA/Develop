using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ProjetoTA.Models;
using ProjetoTA.Services;

namespace ProjetoTA.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsuariosController : ControllerBase
    {
        private readonly IUsuarioService _usuarioService;

        public UsuariosController(IUsuarioService usuarioService)
        {
            _usuarioService = usuarioService;
        }

        [HttpPost("autenticar")]
        public async Task<IActionResult> Autenticar([FromBody] AutenticacaoModel login)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var usuario = await _usuarioService.Autenticar(login.Email, login.Senha);
            if (usuario == null)
            {
                return Unauthorized("Email ou senha inválidos.");
            }

            return Ok(usuario);
        }

        [HttpPost]
        public async Task<IActionResult> Cadastrar([FromBody] UsuarioModel usuarioModel)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            try
            {
                var usuario = await _usuarioService.Cadastrar(usuarioModel);
                return CreatedAtRoute("GetUsuario", new { usuarioId = usuario.UsuarioID }, usuario);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpGet("{usuarioId}")]
        public async Task<IActionResult> GetUsuario(int usuarioId)
        {
            var usuario = await _usuarioService.BuscarPorId(usuarioId);
            if (usuario == null)
            {
                return NotFound();
            }

            return Ok(usuario);
        }

        [HttpPut("{usuarioId}")]
        public async Task<IActionResult> Atualizar(int usuarioId, [FromBody] UsuarioModel usuarioModel)
        {
            if (usuarioId != usuarioModel.UsuarioID)
            {
                return BadRequest("O ID da URL deve corresponder ao ID do usuário no corpo da requisição.");
            }

            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            try
            {
                await _usuarioService.Atualizar(usuarioModel);
                return NoContent();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
