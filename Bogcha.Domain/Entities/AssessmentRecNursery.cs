namespace Bogcha.Domain.Entities;

public class AssessmentRecNursery
{
    public int Id { get; set; }
    public string ChId {  get; set; }
    public string ClassId {  get; set; }
    public DateTime AssessmentDate { get; set; }
    public int Reflection_5 {  get; set; }
    public int Social_development_5 {  get; set; }
    public int Emotional_development_5 { get; set; }
    public int Conflict_resolution_5 {  get; set; }

}
