using System;
using EntitySystem.Server.Files.Services;
using Example.FileManager.Shared;

namespace Example.FileManager.Server.Services;

    public class FileService : FileService<FileReference, PersistentFile, PersistentInfo>
    {
        public FileService(IServiceProvider serviceProvider) : base(serviceProvider)
        {
        }
    }

