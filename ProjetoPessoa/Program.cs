using Microsoft.EntityFrameworkCore;
using ProjetoPessoa.Data;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

private static readonly string _DefaultConnection = "Server=localhost;Database=mydatabase;User Id=myusername;Password=mypassword;";

builder.Services.AddDbContext<MyDbContext>(options =>
options.UseSqlServer(_DefaultConnection));

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

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();




