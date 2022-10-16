using System;
using EntitySystem.Shared.Files.Domain;
using EntitySystem.Shared.Fluent.Domain;

namespace Example.FileManager.Shared;

public class FileReference : Entity, IFileReference
{
    public virtual Guid Guid { get; set; } = Guid.NewGuid();

    public virtual string Mime { get; set; }

    public virtual string Name { get; set; } = "Empty file";

    public virtual long Size { get; set; }
}