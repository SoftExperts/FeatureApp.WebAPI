using Config;
using Database;
using Microsoft.EntityFrameworkCore;
using Services.Chat;

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

builder.Services.AddApiVersioning(options =>
{
    options.ReportApiVersions = true;
    options.AssumeDefaultVersionWhenUnspecified = true;
    options.DefaultApiVersion = new Microsoft.AspNetCore.Mvc.ApiVersion(1, 0);

}) ;

builder.Services.AddVersionedApiExplorer(options =>
{
    options.GroupNameFormat = "'v'VVV";
    options.SubstituteApiVersionInUrl = true;
});

// This code will create the Database in MSSQL Server.
builder.Services.AddDbContext<AppDbContext>(dbOptions => 
dbOptions.UseSqlServer(builder.Configuration.GetConnectionString("AsifProdDb"))
);

//builder.Services.AddCors(options =>
//{
//options.AddDefaultPolicy(
//        builder =>
//        {
//            //builder.WithOrigins("https://localhost:7263", "https://localhost:7087/", "http://localhost:5249/");
//            builder.AllowAnyOrigin();
//        }
//);
//});


//builder.Services.AddCors();

builder.Services.AddCors(options => 
{
    options.AddPolicy("CORSPolicy", 
        builder => 
        builder.AllowAnyMethod()
               .AllowAnyHeader()
               .AllowCredentials()
               .SetIsOriginAllowed((hosts) => true));
});

builder.Services.AddAndConfigureRepositories();
builder.Services.AddAndConfigureServices();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}
else
{
    app.UseHsts();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.UseCors("CORSPolicy");

//app.UseCors(options => options.WithOrigins("www.example.com").AllowAnyMethod().AllowAnyHeader());

app.UseRouting();

app.UseEndpoints(endpoints =>
{
    endpoints.MapHub<ChatHub>("/chatHub");
});

app.MapControllers();

app.Run();
