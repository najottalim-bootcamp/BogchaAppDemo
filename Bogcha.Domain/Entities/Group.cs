namespace Bogcha.Domain.Entities
{
    public class Group
    {
        public int Id { get; set; }
        public string Group_Name { get; set; }
        public int Group_Size { get; set; }
        public bool Group_Aviability { get; set; }
        public DateTime Created_At { get; set; }
        public DateTime Updated_At { get; set; }
        public int Created_By { get; set; }
        public int Updated_By { get; set; }
        public int Teacher_Id { get; set; }


    }
}





