namespace Bogcha.Infrastructure.Services.RevenueServices;

public class RevenueService : IRevenueService
{
    private readonly IRevenueRepository _revenueRepository;
    private readonly IStudentRepository _studentRepository;
    private readonly IMapper _mapper;

    public RevenueService(
        IRevenueRepository revenueRepository,
        IStudentRepository studentRepository,
        IMapper mapper)
    {
        _revenueRepository = revenueRepository;
        _studentRepository = studentRepository;
        _mapper = mapper;
    }

    public async ValueTask<bool> CreateAsync(CreateRevenueDto createRevenueDto)
    {
        Revenue revenue = _mapper.Map<Revenue>(createRevenueDto);
        bool result = await _revenueRepository.CreateAsync(revenue);
        return result;
    }

    public async ValueTask<bool> DeleteAsync(string chId)
    {
        bool result = await _revenueRepository.DeleteAsync(chId);
        return result;
    }

    public async ValueTask<IEnumerable<ViewRevenueDto>> GetAllRevenuesAsync()
    {
        IEnumerable<Student> students = await _studentRepository.GetAllAsync();
        IEnumerable<Revenue> revenues = await _revenueRepository.GetAllAsync();

        if(!(students.Any() && revenues.Any()))
        {
            return Enumerable.Empty<ViewRevenueDto>();
        }
        IEnumerable<ViewRevenueDto> revenueViews = revenues.Join(students,
            rev => rev.ChId,
            st => st.CHId,
            (rev, std) => new ViewRevenueDto()
            {
                CHId = std.CHId,
                ChFName = std.ChFName,
                ChLName = std.ChLName,
                RegistrationFee = rev.RegistrationFee,
                Term1 = rev.Term1,
                Term2 = rev.Term2,
                Term3 = rev.Term3,
                Book = rev.Book,
                InvoiceNo = rev.InvoiceNo,
                RecieptNo = rev.RecieptNo,
            });
        return revenueViews;
    }

    public async ValueTask<ViewRevenueDto> GetRevenueByIdAsync(string id)
    {
        Student? student = await _studentRepository.GetByIdAsync(id);

        Revenue? revenue = await _revenueRepository.GetByIdAsync(id);
        if (student is null || revenue is null)
        {
            return null;
        }
        var revenueView = new ViewRevenueDto()
        {
            CHId = student.CHId,
            ChFName = student.ChFName,
            ChLName = student.ChLName,
            RegistrationFee = revenue.RegistrationFee,
            Term1 = revenue.Term1,
            Term2 = revenue.Term2,
            Term3 = revenue.Term3,
            Book = revenue.Book,
            InvoiceNo = revenue.InvoiceNo,
            RecieptNo = revenue.RecieptNo,
        };
        return revenueView;
    }

    public async ValueTask<bool> UpdateAsync(string chId, UpdateRevenueDto updateRevenueDto)
    {
        Revenue revenue = await _revenueRepository.GetByIdAsync(chId);
        if (revenue is null)
        {
            return false;
        }
        revenue = _mapper.Map<Revenue>(updateRevenueDto);
        revenue.ChId = chId;

        bool result = await _revenueRepository.UpdateAsync(revenue);
        return result;
    }
}
