using EntitySystem.Server.Controllers;
using Example.FileManager.Server.Services;
using Example.FileManager.Shared;
using Microsoft.AspNetCore.Mvc;

namespace Example.FileManager.Server.Controllers;

[Route("api/file-references")]
[ApiController]
public class FileReferenceController : EntityController<FileReferenceService, FileReference>
{
    public FileReferenceController(FileReferenceService entityService) : base(entityService)
    {
    }
}