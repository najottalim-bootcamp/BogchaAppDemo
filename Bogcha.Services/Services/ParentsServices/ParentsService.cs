using Bogcha.Infrastructure.Services.ParentsServices.ParentsDtos;
using System.Windows.Markup;

namespace Bogcha.Infrastructure.Services.ParentsServices;

public class ParentsService : IParentsService
{
    private IParentRepository _parent;
    private IStudentRepository _student;
    private IMapper _mapper;

    public ParentsService(IParentRepository parent,IStudentRepository student,IMapper mapper)
    {
        _parent = parent;
        _student = student;
        _mapper = mapper;
    }

    public async ValueTask<bool> CreateAsync(ViewParentDto viewParentDto)
    {
        var paren = _mapper.Map<Parents>(viewParentDto);
        bool res = await _parent.CreateAsync(paren);
        return res;
    }

    public async ValueTask<bool> DeleteAsync(string chId)
    {
       bool res = await _parent.DeleteAsync(chId);
        return res;
    }

    public async  ValueTask<IEnumerable<ViewParentDto>> GetAllRevenuesAsync()
    {
        var students = await _student.GetAllAsync();
        var parentss = await _parent.GetAllAsync();

        if (!(students.Any() && parentss.Any()))
        {
            return Enumerable.Empty<ViewParentDto>();
        }

        var parentViews = parentss.Join(students,
            par => par.ChId,
            std => std.CHId,
            (parn, strdun) => new ViewParentDto() 
            {
                CHId = strdun.CHId,
                ChFName =strdun.ChFName,
                ChLName =strdun.ChLName,
                FatherFullName = parn.FatherFullName,
                MotherFullName = parn.MotherFullName,
                Passport = parn.Passport,
                StrAddress = parn.StrAddress,
                City = parn.City,
                Region = parn.Region,
                ZipCode = parn.ZipCode,
                PhoneNo1= parn.PhoneNo1,
                PhoneNo2 = parn.PhoneNo2,
                Email = parn.Email,

            });
     
        return parentViews;
    }

    public async ValueTask<ViewParentDto> GetRevenueByIdAsync(string id)
    {
        Student? student = await _student.GetByIdAsync(id);
        Parents? parents = await _parent.GetByIdAsync(id);

        if (parents != null || parents != null)
        {
            return null;
        }

        var parentViews = new ViewParentDto()
        {
            CHId = student.CHId,
            ChFName = student.ChFName,
            ChLName = student.ChLName,
            FatherFullName = parents.FatherFullName,
            MotherFullName = parents.MotherFullName,
            Passport = parents.Passport,
            StrAddress = parents.StrAddress,
            City = parents.City,
            Region = parents.Region,
            ZipCode = parents.ZipCode,
            PhoneNo1 = parents.PhoneNo1,
            PhoneNo2 = parents.PhoneNo2,
            Email = parents.Email,


        };
        return parentViews;

    } 
      

    public async ValueTask<bool> UpdateAsync(string chId, ViewParentDto viewParentDto)
    {
        var repo = await _parent.GetByIdAsync(chId);

        if (repo is null)
        {
            return false;
        }

        var parent = _mapper.Map<Parents>(viewParentDto);
        parent.ChId = chId;

        bool res = await _parent.UpdateAsync(parent);
        return res;
    }
}
