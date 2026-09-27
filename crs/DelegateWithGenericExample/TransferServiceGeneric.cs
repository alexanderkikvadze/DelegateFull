namespace DelegateFullExample.crs.DelegateWithGenericExample;

public class TransferServiceGeneric
{
    public void TransferFunds(
        decimal amount,
        string fromAccount,
        string toAccount,
        NotificationHandlerGeneric<TransferResultDto> notification)
    {
        Console.WriteLine($"Transferring {amount:C} from {fromAccount} to {toAccount}...");

        var result = new TransferResultDto
        {
            Amount = amount,
            FromAccount = fromAccount,
            ToAccount = toAccount,
            IsSuccessful = true
        };

        notification.Invoke(result);
    }
}
