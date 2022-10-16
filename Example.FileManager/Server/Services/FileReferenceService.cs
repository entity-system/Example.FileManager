using System;
using System.Linq.Expressions;
using System.Threading.Tasks;
using EntitySystem.Server.Files.Services;
using EntitySystem.Server.Services;
using Example.FileManager.Shared;

namespace Example.FileManager.Server.Services;

public class FileReferenceService : EntityService<FileReference>, IFileReferenceService<FileReference>
{
    private readonly PersistentInfoService _persistentInfoService;

    public FileReferenceService(IServiceProvider serviceProvider, PersistentInfoService persistentInfoService) : base(serviceProvider)
    {
        _persistentInfoService = persistentInfoService;
    }

    public override async Task DeleteAsync<TValue>(Expression<Func<FileReference, TValue>> selector, bool force = false, params TValue[] values)
    {
        await _persistentInfoService.DeleteAsync(m => m.Reference, selector, force, values);

        await base.DeleteAsync(selector, force, values);
    }
}