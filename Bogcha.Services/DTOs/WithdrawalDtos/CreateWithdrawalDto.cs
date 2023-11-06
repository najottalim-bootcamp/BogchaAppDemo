namespace Bogcha.Services.DTOs.WithdrawalDtos;

public class CreateWithdrawalDto
{
    public string Expense { get; set; }
    public decimal Amount { get; set; }
    public DateTime DatePaid { get; set; }
    [RegularExpression(@"^[A-Z]{2}[0-9]{3}$", ErrorMessage = "WithDrawnBy must match the format 'XX999'")]
    public string WithDrawnBy { get; set; }
}
