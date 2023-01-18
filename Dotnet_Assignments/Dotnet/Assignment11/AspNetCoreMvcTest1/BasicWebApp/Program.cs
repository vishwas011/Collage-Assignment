using BasicWebApp.Services;
var builder = WebApplication.CreateBuilder(args);
builder.Services.AddControllersWithViews();
builder.Services.AddSingleton<IDbContext ,StudentDbContext>();
//builder.Services.AddTransient<IDbContext>();
var app = builder.Build();
app.MapDefaultControllerRoute();
app.Run();
