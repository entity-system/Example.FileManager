using System;
using EntitySystem.Server.Files.Controllers;
using Example.FileManager.Shared;
using Microsoft.AspNetCore.Mvc;

namespace Example.FileManager.Server.Controllers;

[Route("api/file")]
public class FileController : FileController<FileReference>
{
    public FileController(IServiceProvider serviceProvider) : base(serviceProvider)
    {
    }
}