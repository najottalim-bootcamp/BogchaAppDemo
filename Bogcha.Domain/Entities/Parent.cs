namespace Bogcha.Domain.Entities
{
    public class Parent
    {
        public int Id { get; set; }
        public string Parent_FirstName { get; set; }
        public string Parent_LastName { get; set; }
        public string Parent_Email { get; set; }
        public DateTime Created_At { get; set; }
        public DateTime Update_At { get; set; }
        public int Created_By { get; set; }
        public int Updated_By { get; set; }


    }
}

