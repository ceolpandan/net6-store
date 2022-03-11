using Microsoft.EntityFrameworkCore;
using Infrastructure.Data;
using API.Helpers;
using API.Middleware;
using API.Extensions;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();

builder.Services.AddDbContext<StoreContext>(options =>
{
   options.UseSqlite(builder.Configuration.GetConnectionString("DefaultConnection"));
});

builder.Services.AddApplicationServices();


builder.Services.AddAutoMapper(typeof(MappingProfiles));

// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerDocumentation();
builder.Services.AddCors(opt => 
{
   opt.AddPolicy("CorsPolicy", policy => 
   {
      policy.AllowAnyHeader().AllowAnyMethod().WithOrigins("https://localhost:4200");
   });
});

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
app.UseMiddleware<ExceptionMiddleware>();

app.UseStatusCodePagesWithReExecute("/errors/{0}");

app.UseHttpsRedirection();

app.UseStaticFiles();

app.UseCors("CorsPolicy");

app.UseAuthorization();

app.UseSwaggerDocumentation();

app.MapControllers();

app.Run();
