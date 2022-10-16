using EntitySystem.Server.Controllers;
using Example.FileManager.Server.Services;
using Example.FileManager.Shared;
using Microsoft.AspNetCore.Mvc;

namespace Example.FileManager.Server.Controllers;

[Route("api/persistent-infos")]
public class PersistentInfoController : EntityController<PersistentInfoService, PersistentInfo>
{
    public PersistentInfoController(PersistentInfoService persistentInfoService) : base(persistentInfoService)
    {
    }
}