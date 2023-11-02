using Bogcha.Domain.Enums;

namespace Bogcha.Domain.Entities
{
    public class Student
    {
        public int Id { get; set; }
        public string Student_FirstName { get; set; }
        public string Student_LastName { get; set; }
        public Gender Student_Gender { get; set; }
        public DateTime Student_DOB { get; set; }
        public string Student_Address { get; set; }
        public DateTime Attendence_Date { get; set; }
        public Status Status { get; set; }
        public DateTime Ceated_At { get; set; }
        public DateTime Updated_At { get; set; }
        public int Created_By { get; set; }
        public int Updated_By { get; set; }
        public int Class_Id { get; set; }
        public int Parent_Id { get; set; }
    }
}
