namespace Bogcha.Infrastructure.Services.WithdrawalServices.WithdrawalDtos;

public class UpdateWithdrawalDto
{
    [RegularExpression(@"^[A-Z]{3}[0-9]{2}$", ErrorMessage = "WithDrawnBy must match the format 'XXX99'")]
    public string WithDrawnBy { get; set; }
    public string Expense { get; set; }
    public decimal Amount { get; set; }
    public DateTime DatePaid { get; set; }
}
