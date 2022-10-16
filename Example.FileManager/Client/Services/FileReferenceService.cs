using System;
using EntitySystem.Client.Files.Services;
using EntitySystem.Client.Services;
using Example.FileManager.Shared;

namespace Example.FileManager.Client.Services;

public class FileReferenceService : EntityService<FileReference>, IFileReferenceService<FileReference>
{
    public FileReferenceService(IServiceProvider serviceProvider) : base("/api/file-references", serviceProvider)
    {
    }

    public string GetUploadUri(FileReference file)
    {
        return $"/api/file/{file.Guid}";
    }

    public string GetDownloadUri(FileReference file)
    {
        return $"/api/file/{file.Guid}";
    }
}