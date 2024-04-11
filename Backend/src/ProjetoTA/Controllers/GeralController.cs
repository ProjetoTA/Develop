using Microsoft.AspNetCore.Mvc;

namespace ProjetoTA.Controllers;

[ApiController]
[Route("api/[controller]")]
public class GeralControllerController : ControllerBase
{
    public GeralControllerController()
    {

    }

    [HttpGet]
    public string Get()
    {
        return "value";
    }

    [HttpPost]
    public string Post()
    {
        return "value";
    }

    [HttpGet]
    public string Put()
    {
        return "value";
    }

    [HttpGet]
    public string Delete()
    {
        return "value";
    }
}

