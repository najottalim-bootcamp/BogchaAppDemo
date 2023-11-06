namespace Bogcha.DataAccess.Repositories.AuthorizedPickUpRepositories
{
    public interface IAuthorizedPickUpRepository
    {
        public ValueTask<bool> CreateAsync(AuthorizedPickUp authorizedPickUp);
        public ValueTask<bool> UpdateAsync(AuthorizedPickUp authorizedPickUp);
        public ValueTask<bool> DeleteAsync(string ChId);
        public ValueTask<AuthorizedPickUp> GetByIdAsync(string ChId);
        public ValueTask<IEnumerable<AuthorizedPickUp>> GetAllAsync();
    }
}
