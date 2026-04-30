using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using UC000608.Data;
using UC000608.Interfaces;
using UC000608.Services;


var builder = WebApplication.CreateBuilder(args);
builder.Services.AddDbContext<UC000608Context>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("UC000608Context") ?? throw new InvalidOperationException("Connection string 'UC000608Context' not found.")));

builder.Services.AddScoped<IMembroService, MembroService>();
builder.Services.AddScoped<IEntradaService, EntradaService>();

// Add services to the container.
builder.Services.AddControllersWithViews();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
}
app.UseRouting();

app.UseAuthorization();

app.MapStaticAssets();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}")
    .WithStaticAssets();


app.Run();
