﻿namespace Bogcha.DataAccess.Repositories.RegularHealthCheckRepositories;

public interface IRegularHealthCheckRepository
{
    public ValueTask<bool> CreateAsync(RegularHealthCheck regularHealthCheck);
    public ValueTask<bool> UpdateAsync(RegularHealthCheck regularHealthCheck);
    public ValueTask<bool> DeleteAsync(int id);
    public ValueTask<RegularHealthCheck> GetByIdAsync(int id);
    public ValueTask<IEnumerable<RegularHealthCheck>> GetAllAsync();
}
