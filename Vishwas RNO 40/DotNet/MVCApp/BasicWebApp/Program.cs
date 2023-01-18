
var builder = WebApplication.CreateBuilder(args);
builder.Services.AddControllersWithViews();
builder.Services.AddDbContext<BasicWebApp.Services.StudentDbContext>();
var app = builder.Build();
app.MapDefaultControllerRoute();
app.Run();
