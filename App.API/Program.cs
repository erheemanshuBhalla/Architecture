using App.Infrastructure.UnitofWork;
using Architecture_V4.BusinessLogic.Services;
using Architecture_V4.Core.Interfaces;


var builder = WebApplication.CreateBuilder(args);

// Register UnitOfWork with DI (Scoped per request)
builder.Services.AddScoped<IUnitOfWork>(sp =>
{
    var connectionString = builder.Configuration.GetConnectionString("DefaultConnection");
    return new DapperUnitOfWork(connectionString);
});

// 2️⃣ Add Application Services
builder.Services.AddScoped<UserService>();
builder.Services.AddScoped<ProductService>();


// Add services to the container.

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
