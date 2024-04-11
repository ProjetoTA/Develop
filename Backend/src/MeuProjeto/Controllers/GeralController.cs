using Microsoft.AspNetCore.Mvc;

namespace MeuProjeto.Controllers;

[ApiController]
[Route("api/[controller]")]
public class WeatherForecastController : ControllerBase
{
    public GeralController()
    {

    }
    public string Get()
    {
        return "value"
    }
}
