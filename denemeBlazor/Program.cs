using MSS_NewsWeb.Bussines.DependencyResolvers;
using MSS_NewsWeb.Data;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.EntityFrameworkCore;
using SportsStore.Data.Context;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
//Cookie Authentication
builder.Services.AddAuthentication(CookieAuthenticationDefaults.AuthenticationScheme)
    .AddCookie(options =>
    {
        options.ExpireTimeSpan = TimeSpan.FromMinutes(20);
        options.SlidingExpiration = true;
        options.LoginPath = "/Account/Login";
        options.AccessDeniedPath = "/Account/Denied"; //2Farklý rolümüz olduðu için accessDenith olduðunda otomatik olarak User yorum yapabilcek.
    });
builder.DependencyInjection();
builder.Services.AddRazorPages();
builder.Services.AddServerSideBlazor();
builder.Services.AddSingleton<WeatherForecastService>();
builder.Services.AddControllers().AddNewtonsoftJson(opt=>opt.SerializerSettings.ReferenceLoopHandling =Newtonsoft.Json.ReferenceLoopHandling.Ignore);
builder.Services.AddControllersWithViews();

//Todo SeedData Eklenecek , UI en son tasarlanacak , Restful Syntax istekleri yapýlacak ,Docker Image alýnacak , Azure Deploy finishh;


var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
}


app.UseStaticFiles();

app.UseRouting();

app.UseAuthentication();
app.UseAuthorization();

app.UseEndpoints(
    endpoints =>
    {
        endpoints.MapDefaultControllerRoute();
    }
);

app.MapBlazorHub();
app.MapFallbackToPage("/Admin/_Host");

await SeedData.EnsurePopulated(app);

app.Run();

