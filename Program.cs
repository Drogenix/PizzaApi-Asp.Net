using Microsoft.EntityFrameworkCore;
using PizzaApi.Context;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddCors();
builder.Services.AddSwaggerGen();
builder.Services.AddControllers();
builder.Services.AddDbContext<PizzaDbContext>(
    options => options.UseSqlServer("name=ConnectionStrings:DefaultConnection"));

var app = builder.Build();

if (builder.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI(options =>
    {
        options.SwaggerEndpoint("/swagger/v1/swagger.json", "v1");
        options.RoutePrefix = string.Empty;
    });
}
// Configure the HTTP request pipeline.
app.UseHttpsRedirection();

app.UseCors(options =>
{
    options.AllowAnyHeader()
    .AllowAnyMethod()
    .SetIsOriginAllowed((host) => true)
    .AllowCredentials();
});

app.MapControllers();

app.Run();
