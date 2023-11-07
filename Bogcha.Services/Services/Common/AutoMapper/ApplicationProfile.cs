using AutoMapper;
using Bogcha.Services.Services.RevenueServices.RevenueDtos;

namespace Bogcha.Services.Services.Common.AutoMapper;
public class ApplicationProfile : Profile
{
    public ApplicationProfile()
    {
        CreateMap<CreateRevenueDto, Revenue>();
        CreateMap<UpdateRevenueDto, Revenue>();
    }
}
