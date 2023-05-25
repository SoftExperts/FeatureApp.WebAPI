using Config;
using Database;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();


// This code will create the In Memorey Database
//builder.Services.AddDbContext<AppDbContext>(options =>
//{
//    options.UseInMemoryDatabase("FeatureAppDb");
//});

// This code will create the Database in MSSQL Server.
builder.Services.AddDbContext<AppDbContext>(dbOptions => 
dbOptions.UseSqlServer(builder.Configuration.GetConnectionString("AsifProdDb"))
);

builder.Services.AddAndConfigureRepositories();
builder.Services.AddAndConfigureServices();

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
