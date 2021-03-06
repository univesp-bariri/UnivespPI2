using Microsoft.EntityFrameworkCore;
using WebPostgreSQL.Models;
using Npgsql;

var builder = WebApplication.CreateBuilder(args);

var mvcBuilder = builder.Services.AddRazorPages();

var DB_CONNECTION = String.Format("Host=150.136.140.74;Port=5432;Pooling=true;Database=yellowpages;User Id={0};Password={1}", Environment.GetEnvironmentVariable("piuser"),Environment.GetEnvironmentVariable("pipasswd"));

// Add services to the container.
builder.Services.AddControllersWithViews();

builder.Services.AddEntityFrameworkNpgsql()
    .AddDbContext<Contexto>(options =>
    options.UseNpgsql(DB_CONNECTION));

builder.Services.AddRazorPages()
    .AddRazorRuntimeCompilation();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
}

if (builder.Environment.IsDevelopment())
{
    mvcBuilder.AddRazorRuntimeCompilation();
}

app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
