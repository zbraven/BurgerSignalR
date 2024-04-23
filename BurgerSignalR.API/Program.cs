using BurgerSignalR.DataAccessLayer;
using Microsoft.EntityFrameworkCore;
using Microsoft.OpenApi.Models;
using System.Globalization;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();

// Swagger'� yap�land�r
builder.Services.AddSwaggerGen(c =>
{
    c.SwaggerDoc("v1", new OpenApiInfo { Title = "CMMS API", Version = "v1" });
});

// AutoMapper yap�land�rmas�
builder.Services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());

// Veritaban� ba�lant� dizesi
builder.Services.AddDbContext<BurgerContext>(options =>
    options.UseSqlServer(
        builder.Configuration.GetConnectionString("DefaultConnection"),
        x => x.MigrationsAssembly("BurgerSignalR.DataAccessLayer") // Migrations'lar�n bulundu�u assembly'i belirtin
    )
);




var app = builder.Build();

// K�lt�r yap�land�rmas�
var cultureInfo = new CultureInfo("en-US");
CultureInfo.DefaultThreadCurrentCulture = cultureInfo;
CultureInfo.DefaultThreadCurrentUICulture = cultureInfo;

// Swagger UI'� yap�land�r
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "CMMS API V1"));
}


// Middleware'leri yap�land�r
app.UseHttpsRedirection();
app.UseAuthorization();
app.MapControllers();



app.Run();
