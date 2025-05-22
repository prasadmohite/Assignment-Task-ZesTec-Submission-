using EFCore_CF_01.DAL;
using EFCore_CF_01.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();


builder.Services.ConfigureApplicationCookie(options =>
{
    options.LoginPath = "/Account/Login";
});


builder.Services.AddAuthentication()
    .AddGoogle(options =>
    {
        IConfigurationSection googleAuthNSection =
            builder.Configuration.GetSection("Authentication:Google");

        options.ClientId = googleAuthNSection["ClientId"];
        options.ClientSecret = googleAuthNSection["ClientSecret"];
    });

var provider = builder.Services.BuildServiceProvider();   

var config=provider.GetService<IConfiguration>();

builder.Services.AddDbContext<EmpDbcontext>(options => options.UseSqlServer(config.GetConnectionString("Myconnectionstring")));

builder.Services.AddScoped<IEmployeeDAL, EmployeeSqlDAL>();

builder.Services.AddIdentity<IdentityUser, IdentityRole>().AddEntityFrameworkStores<EmpDbcontext>();

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
app.UseAuthentication();    

app.UseAuthorization();

app.MapStaticAssets();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Employee}/{action=Index}/{id?}")
    .WithStaticAssets();


app.Run();
