namespace Bogcha.DataAccess.Repositories.ParentsRepositories;

public interface IParentRepository
{
    public ValueTask<bool> CreateAsync(Parents entity);

    public ValueTask<bool> UpdateAsync(Parents entity);

    public ValueTask<bool> DeleteAsync(string id);

    public ValueTask<Parents> GetByIdAsync(string id);
    public ValueTask<IEnumerable<Parents>> GetAllAsync();
}
