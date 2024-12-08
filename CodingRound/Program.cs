using CodingRound.Controllers;
using CodingRound.Repo;
using CodingRound.Services;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

var conn = builder.Configuration.GetConnectionString("DefaultConnection");

builder.Services.AddDbContext<ApplicationContext>(op => op.UseSqlServer(conn));

builder.Services.AddScoped<IUserrepo ,UserRepo>();
builder.Services.AddScoped<IUserServices ,UserServices>();

builder.Services.AddSingleton<IHttpContextAccessor, HttpContextAccessor>();

//configuration of session
builder.Services.AddSession(options =>
{
    options.IdleTimeout = TimeSpan.FromMinutes(5);
    options.Cookie.IsEssential = true;
    options.Cookie.HttpOnly = true;
});

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
}
app.UseStaticFiles();

app.UseRouting();

//for session
app.UseSession();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
