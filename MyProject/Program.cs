using Business;
using Microsoft.EntityFrameworkCore;
using Models.Data;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllersWithViews();

var connetion = "Server=localhost,1433;Database=InfoTable;User=sa;Password=YourStrong!Passw0rd;TrustServerCertificate=True";
builder.Services.AddDbContext<ApplicationDbContext>(options =>
    options.UseSqlServer(connetion));

//builder.Services.AddDbContext<ApplicationDbContext>(options =>
//    options.UseSqlServer("Server=.;DataBase=InfoTable;Encrypt=False;Integrated Security=True"));

builder.Services.AddScoped<ISearchService, SearchService>();

var app = builder.Build();


if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
