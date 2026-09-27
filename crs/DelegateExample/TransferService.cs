namespace DelegateFullExample.crs.DelegateExample;

public class TransferService
{
    public void TransferFunds(decimal amount, string fromAccount, string toAccount, NotificationHandler? notification)
    {
        // Simulate the transfer process
        Console.WriteLine($"Transferring {amount:C} from {fromAccount} to {toAccount}...");
        // Notify the user about the transfer status
        notification?.Invoke($"Transfer of {amount:C} from {fromAccount} to {toAccount} completed successfully.");
    }
}
