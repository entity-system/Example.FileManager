using System;
using EntitySystem.Server.Files.Services;
using EntitySystem.Server.Services;
using Example.FileManager.Shared;

namespace Example.FileManager.Server.Services;

public class PersistentInfoService : EntityService<PersistentInfo>, IPersistentInfoService<FileReference, PersistentFile, PersistentInfo>
{
    public PersistentInfoService(IServiceProvider serviceProvider) : base(serviceProvider)
    {
    }
}