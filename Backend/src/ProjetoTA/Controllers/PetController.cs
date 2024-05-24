using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ProjetoTA.Models;
using ProjetoTA.Services;

namespace ProjetoTA.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PetsController : ControllerBase
    {
        private readonly IPetService _petService;

        public PetsController(IPetService petService)
        {
            _petService = petService;
        }

        [HttpGet("usuario/{usuarioId}")]
        public async Task<IActionResult> GetPetsPorUsuario(int usuarioId)
        {
            var pets = await _petService.ObterTodosPorUsuarioId(usuarioId);
            if (pets == null || pets.Count == 0)
            {
                return NotFound();
            }

            return Ok(pets);
        }

        [HttpGet("{petId}")]
        public async Task<IActionResult> GetPet(int petId)
        {
            var pet = await _petService.ObterPorId(petId);
            if (pet == null)
            {
                return NotFound();
            }

            return Ok(pet);
        }

        [HttpPost]
        public async Task<IActionResult> CriarPet([FromBody] PetModel petModel)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            try
            {
                await _petService.Cadastrar(petModel);
                return CreatedAtRoute("GetPet", new { petId = petModel.PetID }, petModel);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPut("{petId}")]
        public async Task<IActionResult> AtualizarPet(int petId, [FromBody] PetModel petModel)
        {
            if (petId != petModel.PetID)
            {
                return BadRequest("O ID da URL deve corresponder ao ID do pet no corpo da requisição.");
            }

            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            try
            {
                await _petService.Atualizar(petModel);
                return NoContent();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
