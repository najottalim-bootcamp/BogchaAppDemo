using Bogcha.Infrastructure.Services.AuthorizedPickUpServices.AuthorizedPickUpDTOs;

namespace Bogcha.Infrastructure.Services.AuthorizedPickUpServices
{
    public class AuthorizedPickUpService : IAuthorizedPickUpService
    {
        private IAuthorizedPickUpRepository _authorizedPickUpRepository;
        private IMapper mapper;
        public AuthorizedPickUpService(IAuthorizedPickUpRepository authorizedPickUpRepository, IMapper mapper)
        {
            _authorizedPickUpRepository = authorizedPickUpRepository;
            this.mapper = mapper;
        }
        public async ValueTask<bool> CreateAsync(CreateAuthorizedPickUpDTO authorizedPickUp)
        {
            AuthorizedPickUp authorizedPickUp1 = mapper.Map<AuthorizedPickUp>(authorizedPickUp);
            return await _authorizedPickUpRepository.CreateAsync(authorizedPickUp1);
        }

        public async ValueTask<bool> DeleteAsync(string ChId)
        {
            return await _authorizedPickUpRepository.DeleteAsync(ChId);
        }

        public async ValueTask<IEnumerable<ViewAuthorizedPickUpDTO>> GetAllAsync()
        {
            IEnumerable<ViewAuthorizedPickUpDTO> authorizedPickUpDTOs = mapper.Map<IEnumerable<ViewAuthorizedPickUpDTO>>(await _authorizedPickUpRepository.GetAllAsync());

            return authorizedPickUpDTOs;
        }

        public async ValueTask<ViewAuthorizedPickUpDTO> GetByIdAsync(string ChId)
        {
            ViewAuthorizedPickUpDTO viewAuthorizedPickUpDTO = mapper.Map<ViewAuthorizedPickUpDTO>(_authorizedPickUpRepository.GetByIdAsync(ChId));
            return viewAuthorizedPickUpDTO;
        }

        public async ValueTask<bool> UpdateAsync(string id, UpdateAuthorizedPickUpDTO authorizedPickUp)
        {
            AuthorizedPickUp authorizedPickUp1 = mapper.Map<AuthorizedPickUp>(authorizedPickUp);
            authorizedPickUp1.ChId = id;
            return await _authorizedPickUpRepository.UpdateAsync(authorizedPickUp1);
        }
    }
}
