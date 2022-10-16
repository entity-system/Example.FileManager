using System.ComponentModel.DataAnnotations;
using EntitySystem.Shared.Files.Domain;
using EntitySystem.Shared.Fluent.Domain;

namespace Example.FileManager.Shared;

public class PersistentInfo : Entity, IPersistentInfo<FileReference, PersistentFile>
{
    [Required]
    [ValidateComplexType]
    public virtual FileReference Reference { get; set; }

    [Required]
    [ValidateComplexType]
    public virtual PersistentFile File { get; set; }
}