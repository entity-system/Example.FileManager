using System;
using System.Linq.Expressions;
using System.Threading.Tasks;
using EntitySystem.Server.Files.Services;
using EntitySystem.Server.Services;
using Example.FileManager.Shared;

namespace Example.FileManager.Server.Services;

public class PersistentFileService : EntityService<PersistentFile>, IPersistentFileService<PersistentFile>
{
    private readonly PersistentInfoService _persistentInfoService;

    public PersistentFileService(IServiceProvider serviceProvider, PersistentInfoService persistentInfoService) : base(serviceProvider)
    {
        _persistentInfoService = persistentInfoService;
    }

    public override async Task DeleteAsync<TValue>(Expression<Func<PersistentFile, TValue>> selector, bool force = false, params TValue[] values)
    {
        await _persistentInfoService.DeleteAsync(m => m.File, selector, force, values);

        await base.DeleteAsync(selector, force, values);
    }
}