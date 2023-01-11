using denemeBlazor.Bussines.DependencyResolvers;
using denemeBlazor.Data;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.EntityFrameworkCore;
using SportsStore.Data.Context;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.DependencyInjection();
builder.Services.AddRazorPages();
builder.Services.AddServerSideBlazor();
builder.Services.AddSingleton<WeatherForecastService>();
builder.Services.AddControllersWithViews();


var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
}


app.UseStaticFiles();

app.UseRouting();
app.UseEndpoints(
    endpoints =>
endpoints.MapDefaultControllerRoute()
);

app.MapBlazorHub();
app.MapFallbackToPage("/_Host");

app.Run();
