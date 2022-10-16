using System;
using System.Net.Http;
using EntitySystem.Client.Files;
using EntitySystem.Client.Fluent;
using Example.FileManager.Client;
using Example.FileManager.Client.Services;
using Example.FileManager.Shared;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Microsoft.Extensions.DependencyInjection;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

builder.Services.AddSingleton(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });

builder.Services
    .AddEntitySystemClientFluent<FileReferenceService, FileReference>()
    .AddEntitySystemClientFiles<FileReference, FileReferenceService, PersistentFile, PersistentFileService, PersistentInfo, PersistentInfoService>();

await builder.Build().RunAsync();
