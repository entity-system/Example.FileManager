using System;
using EntitySystem.Client.Files.Services;
using EntitySystem.Client.Services;
using Example.FileManager.Shared;

namespace Example.FileManager.Client.Services;

public class PersistentFileService : EntityService<PersistentFile>, IPersistentFileService<PersistentFile>
{
    public PersistentFileService(IServiceProvider serviceProvider) : base("/api/persistent-files", serviceProvider)
    {
    }
}