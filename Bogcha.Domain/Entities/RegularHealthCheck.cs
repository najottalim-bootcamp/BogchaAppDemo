using System.ComponentModel.DataAnnotations.Schema;

namespace Bogcha.Domain.Entities
{
    public class RegularHealthCheck
    {
        public int Id { get; set; }
        public string ChId { get; set; }
        public DateTime CheckupDate { get; set; }
        public string? Symptom { get; set; }
        public string? ActionRequired { get; set; }

        public virtual Student Studnet { get; set; }
    }
}
