using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ProjetoTA.Models;
using ProjetoTA.Services;

namespace ProjetoTA.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PublicacoesController : ControllerBase
    {
        private readonly IPublicacaoService _publicacaoService;

        public PublicacoesController(IPublicacaoService publicacaoService)
        {
            _publicacaoService = publicacaoService;
        }

        [HttpGet("usuario/{usuarioId}")]
        public async Task<IActionResult> GetPublicacoesPorUsuario(int usuarioId)
        {
            var publicacoes = await _publicacaoService.ObterTodasPorUsuarioId(usuarioId);
            if (publicacoes == null || publicacoes.Count == 0)
            {
                return NotFound();
            }

            return Ok(publicacoes);
        }

        [HttpGet("{publicacaoId}")]
        public async Task<IActionResult> GetPublicacao(int publicacaoId)
        {
            var publicacao = await _publicacaoService.ObterPorId(publicacaoId);
            if (publicacao == null)
            {
                return NotFound();
            }

            return Ok(publicacao);
        }

        [HttpPost]
        public async Task<IActionResult> CriarPublicacao([FromBody] PublicacoesModel publicacaoModel)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            try
            {
                await _publicacaoService.Cadastrar(publicacaoModel);
                return CreatedAtRoute("GetPublicacao", new { publicacaoId = publicacaoModel.FotoID }, publicacaoModel);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPut("{publicacaoId}")]
        public async Task<IActionResult> AtualizarPublicacao(int publicacaoId, [FromBody] PublicacoesModel publicacaoModel)
        {
            if (publicacaoId != publicacaoModel.FotoID)
            {
                return BadRequest("O ID da URL deve corresponder ao ID da publicação no corpo da requisição.");
            }

            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            try
            {
                await _publicacaoService.Atualizar(publicacaoModel);
                return NoContent();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
