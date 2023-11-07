namespace Bogcha.Infrastructure.Services.RegularHealthCheckServices
{
    public interface IRegularHealthCheckService
    {

        public ValueTask<bool> CreateAsync(CreateRegularHealthCheckDto regularHealthCheck);
        public ValueTask<bool> UpdateAsync(int id,UpdateRegularHealthCheckDto regularHealthCheck);
        public ValueTask<bool> DeleteAsync(int id);
        public ValueTask<ViewRegularHealthCheckDto> GetByIdAsync(int id);
        public ValueTask<IEnumerable<ViewRegularHealthCheckDto>> GetAllAsync();
    }
}
