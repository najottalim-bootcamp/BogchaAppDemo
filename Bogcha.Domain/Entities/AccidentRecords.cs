namespace Bogcha.Domain.Entities
{
    public class AccidentRecords
    {
        public int AccNo { get; set; }
        public string ChId { get; set; }
        public DateTime? AccidentDate { get; set; }
        public string? TypeOfAccident { get; set; }
        public string? Location { get; set; }
        public string? FirstAid { get; set; }

        public virtual Student Studnet { get; set; }
    }
}
