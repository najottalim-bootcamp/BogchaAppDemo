
using Bogcha.Infrastructure.Services.StudentServices.StudensDtos;

namespace Bogcha.Infrastructure.Services.Common.AutoMapper;
public class ApplicationProfile : Profile
{
    public ApplicationProfile()
    {
        CreateMap<CreateRevenueDto, Revenue>();
        CreateMap<UpdateRevenueDto, Revenue>();

        CreateMap<CreateWithdrawalDto, Withdrawal>();
        CreateMap<UpdateWithdrawalDto, Withdrawal>();
        CreateMap<CreateStudentsDto, Student>();
    }
}
