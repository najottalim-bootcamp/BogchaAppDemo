using Bogcha.Domain.Entities;
using Bogcha.Infrastructure.Services.AuthorizedPickUpServices.AuthorizedPickUpDTOs;
using Bogcha.Infrastructure.Services.BlackListServices.BlackListDTOs;

namespace Bogcha.Infrastructure.Services.BlackListServices;
public class BlackListService : IBlackListService
{
    private readonly IStudentRepository _studentRepository;
    private IBlackListRepository _blackListRepository;
    private IMapper mapper;

    public BlackListService(IBlackListRepository blackListRepository, IMapper mapper)
    {
        _blackListRepository = blackListRepository;
        this.mapper = mapper;
    }
    public async ValueTask<bool> CreateAsync(CreateBlackListDTO  blackList)
    {
        BlackList blackList1 = mapper.Map<BlackList>(blackList);
        return await _blackListRepository.CreateAsync(blackList1);
    }

    public async ValueTask<bool> DeleteAsync(string ChId)
    {
        return await _blackListRepository.DeleteAsync(ChId);
    }

    public async ValueTask<IEnumerable<ViewBlackListDTO>> GetAllAsync()
    {
        IEnumerable<Student> students = await _studentRepository.GetAllAsync();
        IEnumerable<BlackList> blackLists = await _blackListRepository.GetAllAsync();

        if (!(students.Any() && blackLists.Any()))
        {
            return Enumerable.Empty<ViewBlackListDTO>();
        }
        IEnumerable<ViewBlackListDTO> blackListDTOs = blackLists.Join(
            students,
            blackList => blackList.ChId,
            emp => emp.CHId,
            (blackList, student) => new ViewBlackListDTO()
            {
                CHId = student.CHId,
                ChFName = student.ChFName,
                ChLName = student.ChLName,
                UnauthFName = blackList.UnauthFName,
                UnauthLName = blackList.UnauthLName,
                gender = blackList.gender,
                Passport = blackList.Passport,
                strAddress = blackList.strAddress,
                city = blackList.city,
                state = blackList.state,
                zipCode = blackList.zipCode,
                phoneNo = blackList.phoneNo,
            });
        return blackListDTOs;


    public async ValueTask<ViewBlackListDTO> GetByIdAsync(string ChId)
    {
        ViewBlackListDTO viewBlackListDTOs = mapper.Map<ViewBlackListDTO>(_blackListRepository.GetByIdAsync(ChId));
        return viewBlackListDTOs;
    }

    public async ValueTask<bool> UpdateAsync(string id, UpdateBlackListDTO blackList)
    {
        BlackList blackList1 = mapper.Map<BlackList>(blackList);
        blackList1.ChId = id;
        return await _blackListRepository.UpdateAsync(blackList1);
    }
}
