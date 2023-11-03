namespace Bogcha.Domain.Entities;

public class AssessmentRecPreK
{
    public int Id { get; set; }
    public string ChId { get; set; }
    public string ClassId { get; set; }
    public DateTime AssessmentDate { get; set; }
    public int Alphabet_assessment_50 { get; set; }
    public int Math_assessment_50 { get; set; }
    public int Team_work_50 { get; set; }
    public int Scissor_skills_50 { get; set; }
    public int pattern_assessment_50 { get; set; }
    public int Name_writing_50 {  get; set; }
}
