using FirstApi.Models;
using FirstApi.Services;
using Microsoft.AspNetCore.Mvc;

namespace FirstApi.Controllers;

[ApiController]
[Route("api/[controller]/[action]")]
public class TestController : ControllerBase
{
    public IUserService UserService {get;}
    public IIocService1 IocService1 {get;}
    public IIocService2 IocService2 {get;}
    public TestController(
        IIocService1 iocService1,
        IIocService2 iocService2
        )
    {
        IocService1 = iocService1;
        IocService2 = iocService2;
    }
    [HttpGet]
    public string Get2()
    {
        return UserService.GetUserName();
    }

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
