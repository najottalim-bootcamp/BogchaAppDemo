namespace Bogcha.Domain.Entities
{
    public class Feedback
    {
        public int Id { get; set; }
        public string? Feedback_Message { get; set; }
        public DateTime Created_At { get; set; }
        public DateTime Updated_At { get; set; }
        public int Created_By { get; set; }
        public int Updated_By { get; set; }
        public int Parent_Id { get; set; }
    }
}
