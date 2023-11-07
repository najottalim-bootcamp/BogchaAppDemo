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
    public async ValueTask<bool> CreateAsync(CreateBlackListDTO blackList)
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
    }


    public async ValueTask<ViewBlackListDTO> GetByIdAsync(string id)
    {
        Student? student = await _studentRepository.GetByIdAsync(id);

        BlackList? blackList = await _blackListRepository.GetByIdAsync(id);
        if (student is null || blackList is null)
        {
            return null;
        }
        var blackListView = new ViewBlackListDTO()
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
        };
        return blackListView;
    }

    public async ValueTask<bool> UpdateAsync(string id, UpdateBlackListDTO blackList)
    {
        var blackList1 = await _blackListRepository.GetByIdAsync(id);
        if (blackList1 is null)
        {
            return false;
        }
        blackList1 = mapper.Map<BlackList>(blackList);
        blackList1.ChId = id;

        bool result = await _blackListRepository.UpdateAsync(blackList1);
        return result;
    }
}
