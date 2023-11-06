namespace Bogcha.Services.DTOs.RevenueDtos;
public class UpdateRevenueDto
{
    public decimal? RegistrationFee { get; set; }
    public decimal? Term1 { get; set; }
    public decimal? Term2 { get; set; }
    public decimal? Term3 { get; set; }
    public decimal? Book { get; set; }
    [RegularExpression(@"^[0-9]{8}-[0-9]{3}-[0-9]{3}$", ErrorMessage = "InvoiceNo must match the format 'XXXXXXXX-XXX-XXX'")]
    public string? InvoiceNo { get; set; }
    [RegularExpression(@"^[A-Z]{3}[0-9]{3}$", ErrorMessage = "RecieptNo must match the format 'XXX999'")]
    public string? RecieptNo { get; set; }
}
