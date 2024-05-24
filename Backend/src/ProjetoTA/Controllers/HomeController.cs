using Microsoft.AspNetCore.Mvc;

namespace ProjetoTA.Controllers
{
    [Route("")] 
    [ApiController]
    public class HomeController : ControllerBase
    {

        [HttpGet("publicacoes")]
        public IActionResult RedirectToUsuario()
        {
            return Redirect("/api/usuario");
        }

        [HttpGet("publicacoes")]
        public IActionResult RedirectToPublicacoes()
        {
            return Redirect("/api/publicacoes");
        }

        [HttpGet("comentarios")]
        public IActionResult RedirectToComentarios()
        {
            return Redirect("/api/comentarios");
        }

        [HttpGet("pets")]
        public IActionResult RedirectToPets()
        {
            return Redirect("/api/pets");
        }
    }
}
