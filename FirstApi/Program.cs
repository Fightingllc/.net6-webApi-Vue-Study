var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// 添加策略（解决同源跨域问题） 允许所有的头部请求  any是自己定义
builder.Services.AddCors(c=>c.AddPolicy("any",p=>p.AllowAnyHeader().AllowAnyMethod().AllowAnyOrigin()));
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

app.Run();
