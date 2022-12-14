using Microsoft.EntityFrameworkCore;
using TrafficChallanManagement.Models;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();


// we have to write this code start
builder.Services.AddDbContext<TrafficDbContext>(x => x.UseSqlServer(builder.Configuration.GetConnectionString("dbconn")));
// we have to write this code end

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
}
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
