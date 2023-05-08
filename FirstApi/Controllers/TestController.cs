using FirstApi.Models;
using Microsoft.AspNetCore.Mvc;

namespace FirstApi.Controllers;

[ApiController]
[Route("api/[controller]/[action]")]
public class TestController : ControllerBase
{
    [HttpGet]

    public IActionResult Get()
    {
        return Ok(new TestPostViewModel { I = 1, Name = "morning" });
    }
    [HttpGet]
    public ActionResult<TestPostViewModel> Get1()
    {
        return Ok(new TestPostViewModel { I = 1, Name = "morning" });
    }
}
