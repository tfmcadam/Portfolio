var builder = WebApplication.CreateBuilder(args);
// services brought in before you build
builder.Services.AddControllersWithViews();
var app = builder.Build();

app.UseStaticFiles();
app.UseRouting();
app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller = Home}/{action=index}/{id?}"
);


// keep this at the end
app.Run();
