namespace Bogcha.Services.Services.RegularHealthCheckServices
{
    public class RegularHealthCheckService:IRegularHealthCheckService
    {
        private readonly IRegularHealthCheckRepository _repository;
        public RegularHealthCheckService(IRegularHealthCheckRepository repository)
        {
            _repository = repository;
        }
        public async ValueTask<bool> CreateAsync(RegularHealthCheck regularHealthCheck)
        {
            return await _repository.CreateAsync(regularHealthCheck);
        }

        public async ValueTask<bool> DeleteAsync(int id)
        {
            return await (_repository.DeleteAsync(id));
        }

        public async ValueTask<IEnumerable<RegularHealthCheck>> GetAllAsync()
        {
            return await _repository.GetAllAsync();
        }

        public async ValueTask<RegularHealthCheck> GetByIdAsync(int id)
        {
            return await _repository.GetByIdAsync(id);
        }

        public async ValueTask<bool> UpdateAsync(RegularHealthCheck regularHealthCheck)
        {
            return await _repository.UpdateAsync(regularHealthCheck);
        }
    }
}
