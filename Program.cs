using BlogWebApp.Data;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

// step 13: Inject DbContext file which is already created inside Data floder into this Service container.
// Write options inside it. and then provide connection string

builder.Services.AddDbContext<BlogDbContext>(options =>
options.UseSqlServer(builder.Configuration.GetConnectionString("BlogDbConnectionString")));

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

// step 14: now open NuGet package manager console from tools
// type following commands to use Entity Framework to create database
// 1) Add-Migration "Name of the Migration"
// this command will automatically create a Migrations folder 
// the Initial Migrations.cs file will scan the DbContext and Entity Framework will find that there are
// 2 properties whose tables needs to be created in the databse.
// 2) Update-Database
// this will create tables in the MySql database automatically (Error generated)