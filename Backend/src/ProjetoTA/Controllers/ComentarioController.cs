using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ProjetoTA.Models;
using ProjetoTA.Services;

namespace ProjetoTA.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ComentarioController : ControllerBase
    {
        private readonly IComentarioService _comentarioService;

        public ComentariosController(IComentarioService comentarioService)
        {
            _comentarioService = comentarioService;
        }

        [HttpGet("{publicacaoId}")]
        public async Task<IActionResult> GetComentariosPorPublicacao(int publicacaoId)
        {
            var comentarios = await _comentarioService.ObterTodosPorPublicacaoId(publicacaoId);
            if (comentarios == null || comentarios.Count == 0)
            {
                return NotFound();
            }

            return Ok(comentarios);
        }

        [HttpPost("{publicacaoId}")]
        public async Task<IActionResult> CriarComentario(int publicacaoId, [FromBody] ComentariosModels comentarioModel)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            comentarioModel.FotoID = publicacaoId;

            try
            {
                await _comentarioService.Cadastrar(comentarioModel);
                return CreatedAtRoute("GetComentariosPorPublicacao", new { publicacaoId = publicacaoId }, comentarioModel);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
