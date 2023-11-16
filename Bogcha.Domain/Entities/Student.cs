namespace Bogcha.Domain.Entities;

public class Student
{
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

    public virtual ICollection<Revenue> Revenues { get; set; }
    public virtual ICollection<BlackList> BlackLists { get; set; }
    public virtual ICollection<Attendance> Attendances { get; set; }
    public virtual ICollection<AuthorizedPickUp> AuthorizedPickUps { get; set; }
    public virtual ICollection<AccidentRecords> Accident_Records { get; set; }
    public virtual ICollection<RegularHealthCheck> RegularHealthChecks { get; set; }
    public virtual ICollection<MenuManagement> MenuManagements { get; set; }

}
