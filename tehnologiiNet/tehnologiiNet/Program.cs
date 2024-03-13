using Microsoft.EntityFrameworkCore;
using tehnologiiNet;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
builder.Services.AddDbContext<DatabaseContext>(
    options => options.UseNpgsql("Host=localhost;Port=5432;Database=net;Username=postgres;Password=parkingshare"));// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle


using (var db = new DatabaseContext())
{
    db.Database.Migrate();
}
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