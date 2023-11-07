using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bogcha.Infrastructure.Services.ParentsServices.ParentsDtos;
public class CreateParentsDto
{
    [RegularExpression(@"^[A-Z]{2}[0-9]{3}$", ErrorMessage = "ChId must match the format 'XX999'")]
    public string? ChId { get; set; }
    public string? FatherFullName { get; set; }
    public string MotherFullName { get; set; }
    public string Passport { get; set; }
    public string StrAddress { get; set; }
    public string City { get; set; }
    public string Region { get; set; }
    public string? ZipCode { get; set; }
    public string? PhoneNo1 { get; set; }
    public string? PhoneNo2 { get; set; }
    public string? Email { get; set; }

}