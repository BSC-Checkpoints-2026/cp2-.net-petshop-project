using Microsoft.AspNetCore.Mvc;

namespace PetShop.Controllers;

[ApiController]
[Route("api/[controller]")]
public class HealthController : ControllerBase
{
    [HttpGet]
    public IActionResult Get()
    {
        return Ok(new
        {
            status = "OK",
            message = "API está funcionando"
        });
    }
}