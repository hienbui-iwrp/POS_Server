using Microsoft.Extensions.Options;
using MongoDB.Driver;
using POS_server.Models;
using POS_server.Repositories;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
// get DB info
builder.Services.Configure<DatabaseSetting>(
    builder.Configuration.GetSection("PosDB")
);

builder.Services.AddSingleton<DatabaseSetting>(
    s => s.GetRequiredService<IOptions<DatabaseSetting>>().Value
);
builder.Services.AddSingleton<IMongoClient>(s=> new MongoClient(builder.Configuration.GetValue<string>("PosDB:ConnectionString")));
// add repository
builder.Services.AddScoped<IFoodsRepository, FoodsRepository>();

// enable log
builder.Logging.ClearProviders();
builder.Logging.AddConsole();

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
