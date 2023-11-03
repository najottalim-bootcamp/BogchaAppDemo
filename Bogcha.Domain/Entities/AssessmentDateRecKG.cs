namespace Bogcha.Domain.Entities;

public class AssessmentDateRecKG
{
    public int Id { get; set; }
    public string ChId { get; set; }
    public string ClassId { get; set; }
    public DateTime AssessmentDate { get; set; }
    public int Know_100 { get; set; }
    public int Math_100 { get; set; }
    public int Read_100 { get; set; }
    public int Spell_100 { get; set; }
    public int Camera_Reading_100 { get; set; }
    public int Camere_Spelling_100 { get; set; }
    public int Sentence_reading_100 { get; set; }
    public int Pattern_assessment_100 { get; set; }
    public int Name_writing_100 { get; set; }
}
