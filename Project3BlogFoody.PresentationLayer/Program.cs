using FluentValidation.AspNetCore;
using Project3BlogFoody.BusinessLayer.Abstract;
using Project3BlogFoody.BusinessLayer.Concrete;
using Project3BlogFoody.BusinessLayer.Container;
using Project3BlogFoody.DataAccessLayer.Abstract;
using Project3BlogFoody.DataAccessLayer.Context;
using Project3BlogFoody.DataAccessLayer.EntityFramework;
using Project3BlogFoody.EntityLayer.Concrete;
using Project3BlogFoody.PresentationLayer.Models;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddDbContext<BlogFoodyContext>();
builder.Services.AddIdentity<AppUser, AppRole>().AddEntityFrameworkStores<BlogFoodyContext>().AddErrorDescriber<CustomIdentityErrorValidator>();

builder.Services.ContainerDependencies();

builder.Services.AddControllersWithViews().AddRazorRuntimeCompilation().AddFluentValidation();

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
app.UseAuthentication();
app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.UseEndpoints(endpoints =>
{
    endpoints.MapControllerRoute(
      name: "areas",
      pattern: "{area:exists}/{controller=Home}/{action=Index}/{id?}"
    );
});

app.Run();
