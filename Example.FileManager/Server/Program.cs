using EntitySystem.Server.Files;
using EntitySystem.Server.Fluent;
using Example.FileManager.Server.Controllers;
using Example.FileManager.Server.Services;
using Example.FileManager.Shared;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

var builder = WebApplication.CreateBuilder(args);

builder.Services
    .AddEntitySystemServerFluent<FileReferenceService, FileReference>()
    .AddEntitySystemServerFiles<FileController, FileService, FileReference, FileReferenceService, FileReferenceController, PersistentFile, PersistentFileService, PersistentFileController, PersistentInfo, PersistentInfoService, PersistentInfoController>();

// Add services to the container.

builder.Services.AddControllersWithViews();
builder.Services.AddRazorPages();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseWebAssemblyDebugging();
}
else
{
    app.UseExceptionHandler("/Error");
}

app.UseBlazorFrameworkFiles();
app.UseStaticFiles();

app.UseRouting();


app.MapRazorPages();
app.MapControllers();
app.MapFallbackToFile("index.html");

app.Run();
