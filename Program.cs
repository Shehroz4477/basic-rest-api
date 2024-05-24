using basic_rest_api.Extensions.Registarion.Services;
using basic_rest_api.Interfaces;
using basic_rest_api.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
builder.Services.AddScopedServices();
builder.Services.AddTransientServices();
builder.Services.AddSingletonServices();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();
using(var scopeService = app.Services.CreateScope())
{
    var services = scopeService.ServiceProvider;
    var scopedService = services.GetRequiredService<IScopedService>();
    Console.WriteLine(scopedService.SayHello());
}
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
