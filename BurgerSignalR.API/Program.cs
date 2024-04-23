using BurgerSignalR.DataAccessLayer;
using Microsoft.EntityFrameworkCore;
using Microsoft.OpenApi.Models;
using System.Globalization;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();

// Swagger'ý yapýlandýr
builder.Services.AddSwaggerGen(c =>
{
    c.SwaggerDoc("v1", new OpenApiInfo { Title = "CMMS API", Version = "v1" });
});

// AutoMapper yapýlandýrmasý
builder.Services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());

// Veritabaný baðlantý dizesi
builder.Services.AddDbContext<BurgerContext>(options =>
    options.UseSqlServer(
        builder.Configuration.GetConnectionString("DefaultConnection"),
        x => x.MigrationsAssembly("BurgerSignalR.DataAccessLayer") // Migrations'larýn bulunduðu assembly'i belirtin
    )
);




var app = builder.Build();

// Kültür yapýlandýrmasý
var cultureInfo = new CultureInfo("en-US");
CultureInfo.DefaultThreadCurrentCulture = cultureInfo;
CultureInfo.DefaultThreadCurrentUICulture = cultureInfo;

// Swagger UI'ý yapýlandýr
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "CMMS API V1"));
}


// Middleware'leri yapýlandýr
app.UseHttpsRedirection();
app.UseAuthorization();
app.MapControllers();



app.Run();
