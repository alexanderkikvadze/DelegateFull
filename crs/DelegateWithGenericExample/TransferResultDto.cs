namespace DelegateFullExample.crs.DelegateWithGenericExample;

public class TransferResultDto
{
    public decimal Amount { get; set; }
    public string FromAccount { get; set; } = string.Empty;
    public string ToAccount { get; set; } = string.Empty;
    public bool IsSuccessful { get; set; }
}
