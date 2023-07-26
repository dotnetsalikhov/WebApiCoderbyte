using WebApiCoderbyte.Interfaces;
using WebApiCoderbyte.Repository;

var builder = WebApplication.CreateBuilder(args);


builder.Services.AddControllers();

builder.Services.AddScoped<IElevatorRepository, ElevatorRepository>();

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
