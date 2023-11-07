using AutoMapper;
using Bogcha.Infrastructure.Services.RevenueServices.RevenueDtos;

namespace Bogcha.Infrastructure.Services.Common.AutoMapper;
public class ApplicationProfile : Profile
{
    public ApplicationProfile()
    {
        CreateMap<CreateRevenueDto, Revenue>();
        CreateMap<UpdateRevenueDto, Revenue>();
    }
}
