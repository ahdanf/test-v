using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using TestV.Data;
var builder = WebApplication.CreateBuilder(args);
builder.Services.AddDbContext<TestVContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("TestVContext") ?? throw new InvalidOperationException("Connection string 'TestVContext' not found.")));

// Add services to the container.
builder.Services.AddControllersWithViews();

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