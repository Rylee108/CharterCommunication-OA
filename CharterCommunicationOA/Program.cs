using CharterCommunicationCore.Contracts.Repositories;
using CharterCommunicationCore.Contracts.Services;
using CharterCommunicationInfrastructure.Repositories;
using CharterCommunicationInfrastructure.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddScoped<ICCTransactionRepository,CCTransactionRepository>();
builder.Services.AddScoped<ICCTransactionServices, CCTransactionServices>();


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
