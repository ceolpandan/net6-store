using Core.Interfaces;
using Microsoft.EntityFrameworkCore;
using Infrastructure.Data;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
builder.Services.AddDbContext<StoreContext>(options =>
{
   options.UseSqlite(builder.Configuration.GetConnectionString("DefaultConnection"));
});
builder.Services.AddScoped<IProductRepository, ProductRepository>();

// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();
// using (var scope = app.Services.CreateScope())
// {
//     var services = scope.ServiceProvider;
//     var loggerFactory = services.GetRequiredService<ILoggerFactory>();
//     try
//     {
//         var context = services.GetRequiredService<StoreContext>();
//         //await context.Database.MigrateAsync();
//         await StoreContextSeed.SeedAsync(context, loggerFactory);
//     }
//     catch (Exception ex)
//     {
//         var logger = loggerFactory.CreateLogger<Program>();
//         logger.LogError(ex, "Error occured during migration");
//     }
// }

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