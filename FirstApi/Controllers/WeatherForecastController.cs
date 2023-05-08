using FirstApi.Models;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;

namespace FirstApi.Controllers;

[EnableCors("any")]
[ApiController]
// 使用路由方法根据方法名来匹配路由[action]
// 也可以直接在每个方法上加路由 相当于在控制器Controller上加了 
[Route("api/[controller]/[action]")]
public class WeatherForecastController : ControllerBase
{
    // 强制传参写在HttpGet里 伪静态
    // 如果不强制 就是动态地址 根据穿的值不同获取的数据是不同的 由？拼接
    

    
    [HttpGet("{i}/{name}")]
    // [Route("Get1")]
    public string Get(int i,string name)
    {
        return name + i;
    }
    // 路由规则可以自定义 不是一定要用 '/'
    [HttpGet("{i}-{name}")]

    // 插入数据 （增）
    // 获取的数据与前端穿过来的不一致 需要建立一个数据模型用来改变数据格式
    // TestPostViewModel 上传的请求实体
    [HttpPost]
    public string Post(TestPostViewModel model)
    {
        return model.I + model.Name;
    }
    // 修改数据 （改） 一般是 id + 实体
    [HttpPut]
    public void Put(int id, TestputViewModel model)
    {
    }
    [HttpDelete]
    public void Delete(int id)
    {
    }
}
