
using Microsoft.EntityFrameworkCore;
using sport.Models;


var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

//add the connection dbcontext and connection string
builder.Services.AddDbContext<DbContext>(opts =>
{
    opts.UseSqlServer(builder.Configuration["ConnectionStrings:HubStoreConnection"]);
});

//add context classes and services for dependency
builder.Services.AddScoped<IHubConnection, HubConnection>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseRouting();

app.UseAuthorization();

app.MapStaticAssets();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}")
    .WithStaticAssets();


app.Run();
