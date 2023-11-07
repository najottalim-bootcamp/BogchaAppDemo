using Bogcha.DataAccess.Repositories.AuthorizedPickUpRepositories;
using Bogcha.Infrastructure.Services.AuthorizedPickUpServices.AuthorizedPickUpDTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bogcha.Infrastructure.Services.AuthorizedPickUpServices
{
    public interface IAuthorizedPickUpService
    {
        public ValueTask<bool> CreateAsync(CreateAuthorizedPickUpDTO authorizedPickUp);
        public ValueTask<bool> UpdateAsync(string id ,UpdateAuthorizedPickUpDTO authorizedPickUp);
        public ValueTask<bool> DeleteAsync(string ChId);
        public ValueTask<ViewAuthorizedPickUpDTO> GetByIdAsync(string ChId);
        public ValueTask<IEnumerable<ViewAuthorizedPickUpDTO>> GetAllAsync();

    }
}
