using Microsoft.EntityFrameworkCore;
using SportsPro.Models;
using Microsoft.Extensions.DependencyInjection;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddDbContext<SportProContext>(options =>
    options.UseSqlite(builder.Configuration.GetConnectionString("SportProContext") ?? throw new InvalidOperationException("Connection string 'SportProContext' not found.")));

// Add services to the container.
builder.Services.AddRouting(options => {
    options.LowercaseUrls = true;
    options.AppendTrailingSlash = true;
});

builder.Services.AddControllersWithViews();

builder.Services.AddDbContext<SportsProContext>(options =>
    options.UseSqlite(builder.Configuration.GetConnectionString("SportsPro")));

//Add services above
var app = builder.Build();
//config services below

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
