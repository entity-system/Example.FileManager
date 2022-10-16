using EntitySystem.Shared.Files.Domain;
using EntitySystem.Shared.Fluent.Attributes;
using EntitySystem.Shared.Fluent.Domain;

namespace Example.FileManager.Shared;

public class PersistentFile : Entity, IPersistentFile
{
    public virtual string Mime { get; set; }

    public virtual string Name { get; set; }

    public virtual string Storage { get; set; }

    public virtual long Size { get; set; }

    [Indexed]
    public virtual string Hash { get; set; }
}