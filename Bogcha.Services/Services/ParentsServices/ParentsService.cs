namespace Bogcha.Infrastructure.Services.ParentsServices;

public class ParentsService : IParentsService
{
    private IParentRepository _parent;

    public ParentsService(IParentRepository parent)
    {
        _parent = parent;
    }
    public async ValueTask<bool> CreateAsync(Parents entity)
    {
        return await _parent.CreateAsync(entity);
    }

    public async ValueTask<bool> DeleteAsync(string id)
    {
        return await _parent.DeleteAsync(id);
    }

    public async ValueTask<IEnumerable<Parents>> GetAllAsync()
    {
        return await _parent.GetAllAsync();
    }

    public async ValueTask<Parents> GetByIdAsync(string id)
    {
        return await _parent.GetByIdAsync(id);
    }

    public async ValueTask<bool> UpdateAsync(Parents entity)
    {
        return await _parent.UpdateAsync(entity);
    }
}
