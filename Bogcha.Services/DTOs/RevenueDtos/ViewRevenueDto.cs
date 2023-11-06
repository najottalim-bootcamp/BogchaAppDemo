namespace Bogcha.Services.DTOs.RevenueDtos;
public class ViewRevenueDto
{
    public string CHId { get; set; }
    public string ChFName { get; set; }
    public string ChLName { get; set; }
    public decimal? RegistrationFee { get; set; }
    public decimal? Term1 { get; set; }
    public decimal? Term2 { get; set; }
    public decimal? Term3 { get; set; }
    public decimal? Book { get; set; }
    public string? InvoiceNo { get; set; }
    public string? RecieptNo { get; set; }
}
