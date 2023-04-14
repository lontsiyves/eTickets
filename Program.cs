using eTickets.Data;
using eTickets.Data.Services;
using Microsoft.AspNetCore.Hosting.Server;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);
// ;
var cs = "Server = myServerAddress; Port = 3306; Database = myDataBase; Uid = myUsername; Pwd = myPassword";

// Add services to the container.
builder.Services.AddControllersWithViews();
builder.Services.AddDbContextPool<AppDbContext>(optionsAction: options => options.UseMySql(cs, ServerVersion.AutoDetect(cs)));
builder.Services.AddScoped<IActorServices, ActorsService>();



var app = builder.Build();

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
