using MinhaApiSegura.Repository;
using MinhaApiSegura.Repository.Interfaces;
using MinhaApiSegura.Services;
using MinhaApiSegura.Services.Interfaces;

var builder = WebApplication.CreateBuilder(args);


builder.Services.AddScoped<IUserRepository, UserRepository>();
builder.Services.AddScoped<IUserService, UserService>();

builder.Services.AddControllers();


builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

app.UseSwagger();
app.UseSwaggerUI();

app.MapControllers();

app.Run();