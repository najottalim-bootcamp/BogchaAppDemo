namespace Bogcha.Infrastructure.Services.ImmunizationRecordServices.ImmunizationRecordDTOs;
public class ViewImmunizationRecordDTO
{
    public int Id { get; set; }
    public string CHId { get; set; }
    public string ChFName { get; set; }
    public string ChLName { get; set; }

    public string? Chickenpox { get; set; }
    public string? Diphtheria_Tetanus_WhoopingCough { get; set; }
    public string? Haemophilus_influenza_typeB { get; set; }
    public string? Hepatsis_A { get; set; }
    public string? Hepatsis_B { get; set; }
    public string? Influenza { get; set; }
    public string? Measles { get; set; }
    public string? Meningococcal { get; set; }
    public string? Pneumococcal { get; set; }
    public string? Polio { get; set; }
    public string? Rotavirus { get; set; }
}
