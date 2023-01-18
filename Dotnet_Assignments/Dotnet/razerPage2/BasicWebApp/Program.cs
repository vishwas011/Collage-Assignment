using BasicWebApp.services;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddRazorPages();
builder.Services.AddSingleton<ISimpleInterest,SimpleInterest>();
var app = builder.Build();
app.MapRazorPages();
app.MapPost("/Interest",DoCalculation);
app.Run();


async Task DoCalculation(HttpRequest request,HttpResponse response,ISimpleInterest interest)
{
    var amount =double.Parse(request.Form["Amount"]);
    var rate =double.Parse(request.Form["Rate"]);
    var period =int.Parse(request.Form["Period"]);
    await response.WriteAsync(@$"
    <html>
    <body>
    <h1>The Simple Interest is {interest.Calculate(amount,rate,period)}<h1>
    </body>
    </html>");
}