namespace Bogcha.Domain.Entities;

public class Withdrawal
{
    public int Id { get; set; }
    public string Expense { get; set; }
    public decimal Amount { get; set; }
    public DateTime DatePaid { get; set; }
    public string WithDrawnBy { get; set; }
}
