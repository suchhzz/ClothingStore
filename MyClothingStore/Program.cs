using ClothingStore.DataAccess;
using ClothingStore.Models.Abstracts;
using ClothingStore.Models.TempDb;
using ClothingStore.Repository.Repositories;
using ClothingStore.Services.Services;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

builder.Services.Configure<IISServerOptions>(options =>
{
    options.AllowSynchronousIO = true;
}); 

builder.Services.AddDbContext<ClothingStoreDbContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection"), 
    builder => builder.MigrationsAssembly("MyClothingStore")));

builder.Services.AddScoped<IProductRepository, ProductRepository>();
builder.Services.AddScoped<IProductService, ProductService>();
builder.Services.AddScoped<IAdminService, AdminService>();
builder.Services.AddScoped<IOtherParametersRepository, OtherParametersRepository>();
builder.Services.AddScoped<IOtherParametersService, OtherParametersService>();
builder.Services.AddScoped<IImageService, ImageService>();
builder.Services.AddTransient<TempProductDatabase>();

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
    pattern: "{controller=Product}/{action=Index}/{id?}");

app.Run();
