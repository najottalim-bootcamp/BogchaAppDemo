using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bogcha.Infrastructure.Services.StudentServices.StudensDtos;
public class CreateStudentsDto
{
    [RegularExpression(@"^[A-Z]{2}[0-9]{3}$", ErrorMessage = "CHpId must match the format 'XX999'")]
    public string CHId { get; set; }
    public string ChFName { get; set; }
    public string ChLName { get; set; }
    public string Gender { get; set; }
    public DateTime ChDoB { get; set; }
    public DateTime RegisteredDate { get; set; }
    public DateTime EnrollmentDate { get; set; }
    public string StAddress { get; set; }
    public string City { get; set; }
    public string Region { get; set; }
    public string? ZipCode { get; set; }
    public string? PhyImpairment { get; set; }
    public string? AllergyType { get; set; }
    public string? AllergySymptom { get; set; }
}
