namespace Bogcha.DataAccess.Repositories.AuthorizedPickUpRepositories
{
    public interface IAuthorizedPickUpRepository
    {
        public ValueTask<bool> CreateAsync(AuthorizedPickUp authorizedPickUp);
        public ValueTask<bool> UpdateAsync(int id, AuthorizedPickUp authorizedPickUp);
        public ValueTask<bool> DeleteAsync(int id);
        public ValueTask<bool> GetByIdAsync(int id);
        public ValueTask<IEnumerable<AuthorizedPickUp>> GetAllAsync();
    }
}
