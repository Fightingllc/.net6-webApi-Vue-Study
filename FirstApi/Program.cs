using FirstApi.Models;
using FirstApi.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// 添加策略（解决同源跨域问题） 允许所有的头部请求  any是自己定义
builder.Services.AddCors(c=>c.AddPolicy("any",p=>p.AllowAnyHeader().AllowAnyMethod().AllowAnyOrigin()));

// 依赖注入 IUserService服务类型  UserService实现类型
builder.Services.AddTransient<IUserService,UserService>();

// 注册所有服务
builder.Services.AddTransient<IIocService1,IocService1>();
builder.Services.AddTransient(typeof(IIocService2),typeof(IocService2));
builder.Services.AddTransient<ISingletonService,SingletonService>();
builder.Services.AddTransient<IScopedService,ScopedService>();
builder.Services.AddTransient<ITransientService,TransientService>();

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}
// 使用 然后需要的控制器中导入使用
app.UseCors();

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

// Minimal apis
// app.MapGet("/", () => "Have a good day!");
// 传一个委托
app.MapGet("/", HelloWorld.Hello);

string Hi() => "Hi";
app.MapGet("/string", Hi);

// 标准委托写法
app.MapGet("/stander", delegate() {
    return "Stander";
});

// 限制路由匹配 正则
app.MapGet("/{id:regex(^[a-z0-9]+$)}", delegate(string id) {
    return id;
});

app.MapPost("/", (TestPostViewModel model) => {
    return model;
});


app.Run();

public class HelloWorld
{
    public static string Hello()
    {
        return "Hello world";
    }
}