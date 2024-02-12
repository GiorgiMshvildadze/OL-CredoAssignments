using Microsoft.EntityFrameworkCore;
using ToDoMigrations.Db;

var builder = WebApplication.CreateBuilder(args);


var connectionString = "Server = LHO10068951\\SQLEXPRESS; Integrated Security = SSPI; TrustServerCertificate = True; ";
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
var scope = app.Services.CreateScope();
var db = scope.ServiceProvider.GetRequiredService<ToDoContext>();
db.Database.Migrate();

app.Run();
