using Microsoft.AspNetCore.Mvc;

namespace FirstApi.Controllers;

[ApiController]
[Route("api/[controller]")]
public class TestController : ControllerBase
{
   [HttpGet]

   public string Get() 
   {
    return "Test";
   }
}
