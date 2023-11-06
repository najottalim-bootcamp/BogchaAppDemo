namespace Bogcha.Services.DTOs.RevenueDtos;

public class CreateRevenueDto
{
    [RegularExpression(@"^[A-Z]{2}[0-9]{3}$", ErrorMessage = "ChId must match the format 'XX999'")]
    public string ChId { get; set; }
    public decimal? RegistrationFee { get; set; }
    public decimal? Term1 { get; set; }
    public decimal? Term2 { get; set; }
    public decimal? Term3 { get; set; }
    public decimal? Book { get; set; }
    [RegularExpression(@"^[0-9]{8}-[0-9]{3}-[0-9]{3}$", ErrorMessage = "InvoiceNo must match the format 'XXXXXXXX-XXX-XXX'")]
    public string? InvoiceNo { get; set; }
    [RegularExpression(@"^[A-Z]{3}[0-9]{3}$", ErrorMessage = "RecieptNo must match the format 'AAAXXX'")]
    public string? RecieptNo { get; set; }
}
