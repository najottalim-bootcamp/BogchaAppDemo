namespace Bogcha.Infrastructure.Services.WithdrawalServices.WithdrawalDtos;

public class CreateWithdrawalDto
{
    [RegularExpression(@"^[A-Z]{2}[0-9]{3}$", ErrorMessage = "WithDrawnBy must match the format 'XX999'")]
    public string WithDrawnBy { get; set; }
    public string Expense { get; set; }
    public decimal Amount { get; set; }
    public DateTime DatePaid { get; set; }
    
}
