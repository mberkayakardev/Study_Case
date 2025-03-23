using Core.Utilities.Managers;
using Microsoft.Extensions.FileProviders;
using MVCUI.Models;
using NToastNotify;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllersWithViews()
                .AddRazorRuntimeCompilation()
                .AddNToastNotifyToastr(new ToastrOptions
                {
                    PositionClass = ToastPositions.TopRight,
                    TimeOut = 3000,
                    ProgressBar = true
                });


builder.Services.Configure<AppConfigReadModel>(builder.Configuration.GetSection("ApiSettings"));
builder.Services.AddHttpClient();
builder.Services.AddMemoryCache();
builder.Services.AddScoped<MemoryCacheManager>();

builder.Services.AddSession(options =>
{
    options.IdleTimeout = TimeSpan.FromMinutes(30); // Oturum s�resi
    options.Cookie.HttpOnly = true;
    options.Cookie.IsEssential = true;
});

builder.Services.AddAuthentication("MyCookieAuth")
    .AddCookie("MyCookieAuth", options =>
    {
        options.LoginPath = "/Layout/Account/Singin";
        options.AccessDeniedPath = "/Layout/Account/AccessDenied";
        options.Cookie.Name = "ECommerceCookie";
        options.ExpireTimeSpan = TimeSpan.FromMinutes(30);
    });


builder.Services.AddAuthorization();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
    app.UseDeveloperExceptionPage();

else
{
    app.UseExceptionHandler("/exception");
    app.UseHsts();
}
app.UseNToastNotify();


app.UseStatusCodePagesWithReExecute("/Error/{0}"); // Costume Exception Handler

app.UseHttpsRedirection();

app.UseStaticFiles();
app.UseStaticFiles(new StaticFileOptions
{
    RequestPath = "/npm",
    FileProvider = new PhysicalFileProvider(Path.Combine(Directory.GetCurrentDirectory() + "/node_modules"))

});

app.UseRouting();

app.UseSession();


app.UseAuthentication();
app.UseAuthorization();

#region Costume Middlewares

#endregion


app.UseEndpoints(e =>
{
    e.MapControllerRoute(name: "defaults", pattern: "{Area=Layout}/{Controller=Home}/{Action=Index}/{id?}");
});


app.Run();