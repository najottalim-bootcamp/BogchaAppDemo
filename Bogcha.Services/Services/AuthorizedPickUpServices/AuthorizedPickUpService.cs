using Bogcha.DataAccess.Repositories.AuthorizedPickUpRepositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bogcha.Services.Services.AuthorizedPickUpServices
{
    public class AuthorizedPickUpService:IAuthorizedPickUpService
    {
        private IAuthorizedPickUpRepository _authorizedPickUpRepository;

        public AuthorizedPickUpService(IAuthorizedPickUpRepository authorizedPickUpRepository)
        {
            _authorizedPickUpRepository = authorizedPickUpRepository;
        }
        public async ValueTask<bool> CreateAsync(AuthorizedPickUp authorizedPickUp)
        {
            return await _authorizedPickUpRepository.CreateAsync(authorizedPickUp);
        }

        public async ValueTask<bool> DeleteAsync(string ChId)
        {
            return await _authorizedPickUpRepository.DeleteAsync(ChId);
        }

        public async ValueTask<IEnumerable<AuthorizedPickUp>> GetAllAsync()
        {
            return await _authorizedPickUpRepository.GetAllAsync();
        }

        public async ValueTask<AuthorizedPickUp> GetByIdAsync(string ChId)
        {
            return await _authorizedPickUpRepository.GetByIdAsync(ChId);
        }

        public async ValueTask<bool> UpdateAsync(AuthorizedPickUp authorizedPickUp)
        {
            return await _authorizedPickUpRepository.UpdateAsync( authorizedPickUp);
        }
    }
}
