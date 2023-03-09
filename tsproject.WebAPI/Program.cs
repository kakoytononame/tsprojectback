

using tsproject.Application;
using tsproject.Infrastructure;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddCors(options =>
{
    options.AddPolicy("Accessforclient",
                      policy =>
                      {
                          policy.WithOrigins("http://localhost:3000",
                                              "http://localhost:3001");
                      });
});
builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddServicesInfrastructure(builder.Configuration);
builder.Services.AddServicesApplication(builder.Configuration);
var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}
app.UseCors("Accessforclient");

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
