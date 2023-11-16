using System.ComponentModel.DataAnnotations.Schema;

namespace Bogcha.Domain.Entities;

public class BlackList
{
    public string ChId { get; set; }
    public string UnauthFName { get; set; }
    public string UnauthLName { get; set; }
    public string gender { get; set; }
    public string Passport { get; set; }
    public string strAddress { get; set; }
    public string city { get; set; }
    public string state { get; set; }
    public string zipCode { get; set; }
    public string phoneNo { get; set; }

    [ForeignKey(nameof(ChId))]
    public Student Studnet { get; set; }
}
