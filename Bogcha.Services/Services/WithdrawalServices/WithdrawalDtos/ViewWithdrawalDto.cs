namespace Bogcha.Infrastructure.Services.WithdrawalServices.WithdrawalDtos;
public class ViewWithdrawalDto
{
    public int Id { get; set; }
    public string Expense { get; set; }
    public decimal Amount { get; set; }
    public DateTime DatePaid { get; set; }
    public string WithDrawnBy { get; set; }
    public string EmployeeFName { get; set; }
    public string EmployeeLName { get; set; }
    public string Department { get; set; }
}
