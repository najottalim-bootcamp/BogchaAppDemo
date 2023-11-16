using System.ComponentModel.DataAnnotations.Schema;

namespace Bogcha.Domain.Entities;

public class Revenue
{
    public string ChId { get; set; }
    public decimal? RegistrationFee { get; set; }
    public decimal? Term1 { get; set; }
    public decimal? Term2 { get; set; }
    public decimal? Term3 { get; set; }
    public decimal? Book { get; set; }
    public string? InvoiceNo { get; set; }
    public string? RecieptNo { get; set; }

    [ForeignKey(nameof(ChId))]
    public Student Studnet { get; set; }
}
