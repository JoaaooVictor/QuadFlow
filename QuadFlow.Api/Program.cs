using Auth.Application.Utils;
using Auth.Infrastructure.Injection;
using Companies.Infrastructure.Injection;
using QuadFlow.Api.Injection;
using Users.Infrastructure.Injection;

var builder = WebApplication.CreateBuilder(args);
var connectionString = builder.Configuration.GetConnectionString("DefaultConnection");

builder.Services.Configure<JwtConfig>(builder.Configuration.GetSection("Jwt"));
builder.Services.AddAuthConfiguration(builder.Configuration);

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddInfrastructureWeb();
builder.Services.AddInfrastructureCompany(connectionString!);
builder.Services.AddInfrastructureUser(connectionString!);

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
	app.UseSwagger();
	app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthentication();

app.UseAuthorization();

app.MapControllers();

app.Run();
