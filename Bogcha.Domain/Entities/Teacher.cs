namespace Bogcha.Domain.Entities
{
    public class Teacher
    {
        public int Id { get; set; }
        public string Teacher_Name { get; set; }
        public string Teacher_Phone { get; set; }
        public string Teacher_Email { get; }
        public DateTime Created_At { get; set; }
        public DateTime Updated_At { get; set; }
        public int Created_By { get; set; }
        public int Updated_By { get; set; }



    }
}




