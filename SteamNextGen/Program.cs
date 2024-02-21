using Microsoft.EntityFrameworkCore;
using SteamNextGen.Data;
using SteamNextGen.Models.Interface;
using SteamNextGen.Models.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();
builder.Services.AddScoped<IProductRepository, ProductRepository>();
builder.Services.AddScoped<IShoppingCartRepository,ShoppingCartRepository >(ShoppingCartRepository.GetCart);
builder.Services.AddScoped<IContactRepository, ContactRepository>();
builder.Services.AddDbContext<SteamDBContext>(option => option.UseSqlServer(builder.Configuration.GetConnectionString("SteamDbContextConnection")));
builder.Services.AddSession();
builder.Services.AddHttpContextAccessor();

var app = builder.Build();
app.UseSession();
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
    pattern: "{controller=Product}/{action=Shop}/{id?}");

app.Run();
