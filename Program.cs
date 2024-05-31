using Gestion_de_citas.Data;
using Gestion_de_citas.Services.Citas;
using Gestion_de_citas.Services.Especialidades;
using Gestion_de_citas.Services.Medicos;
using Gestion_de_citas.Services.Pacientes;
using Gestion_de_citas.Services.Tratamientos;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddControllers();

builder.Services.AddScoped<ICitasRepository, CitasRepository>();
builder.Services.AddScoped<IEspecialidadesRepository, EspecialidadesRepository>();
builder.Services.AddScoped<IMedicosRepository, MedicosRepository>();
builder.Services.AddScoped<IPacientesRepository, PacientesRepository>();
builder.Services.AddScoped<ITratamientosRepository, TratamientosRepository>();

builder.Services.AddDbContext<BaseContext> (options => 
    options.UseMySql(
        builder.Configuration.GetConnectionString("MySqlConnection"),
        Microsoft.EntityFrameworkCore.ServerVersion.Parse("8.0.20-mysql")));

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

var summaries = new[]
{
    "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
};

app.MapGet("/weatherforecast", () =>
{
    var forecast =  Enumerable.Range(1, 5).Select(index =>
        new WeatherForecast
        (
            DateOnly.FromDateTime(DateTime.Now.AddDays(index)),
            Random.Shared.Next(-20, 55),
            summaries[Random.Shared.Next(summaries.Length)]
        ))
        .ToArray();
    return forecast;
})
.WithName("GetWeatherForecast")
.WithOpenApi();

app.MapControllers();

app.Run();

record WeatherForecast(DateOnly Date, int TemperatureC, string? Summary)
{
    public int TemperatureF => 32 + (int)(TemperatureC / 0.5556);
}
