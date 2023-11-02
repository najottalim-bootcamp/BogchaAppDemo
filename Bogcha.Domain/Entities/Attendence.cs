using Bogcha.Domain.Enums;

namespace Bogcha.Domain.Entities
{
    public class Attendence
    {

        public int Id { get; set; }
        public int ClassId { get; set; }
        public int StudentId { get; set; }
        public Attendence_Status_Enum Attendence_Status { get; set; }
        public DateTime Attendence_Date { get; set; }
        public DateTime Created_At { get; set; }
        public DateTime Updated_At { get; set; }
        public int Created_By { get; set; }
        public int Updated_By { get; set; }
    }
}
