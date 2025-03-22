using Core.Utilities.Managers;
using Microsoft.Extensions.FileProviders;
using MVCUI.Models;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllersWithViews()
                .AddRazorRuntimeCompilation();

builder.Services.Configure<AppConfigReadModel>(builder.Configuration.GetSection("ApiSettings"));
builder.Services.AddHttpClient();
builder.Services.AddMemoryCache();
builder.Services.AddScoped<MemoryCacheManager>();


var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
    app.UseDeveloperExceptionPage();

else
{
    app.UseExceptionHandler("/exception");
    app.UseHsts();
}

app.UseStatusCodePagesWithReExecute("/Error/{0}"); // Costume Exception Handler

app.UseHttpsRedirection();

app.UseStaticFiles();
app.UseStaticFiles(new StaticFileOptions
{
    RequestPath = "/npm",
    FileProvider = new PhysicalFileProvider(Path.Combine(Directory.GetCurrentDirectory() + "/node_modules"))

});

app.UseRouting();


app.UseAuthentication();
app.UseAuthorization();

#region Costume Middlewares

#endregion


app.UseEndpoints(e =>
{
    e.MapControllerRoute(name: "defaults", pattern: "{Area=Layout}/{Controller=Home}/{Action=Index}/{id?}");
});


app.Run();