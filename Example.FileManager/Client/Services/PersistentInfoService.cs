using System;
using EntitySystem.Client.Files.Services;
using EntitySystem.Client.Services;
using Example.FileManager.Shared;

namespace Example.FileManager.Client.Services;

public class PersistentInfoService : EntityService<PersistentInfo>, IPersistentInfoService<FileReference, PersistentFile, PersistentInfo>
{
    public PersistentInfoService(IServiceProvider serviceProvider) : base("/api/persistent-infos", serviceProvider)
    {
    }
}