namespace DelegateFullExample.crs.DelegateWithGenericExample;

public class TransferNotificationServiceGeneric
{
    public static void SendSms(TransferResultDto result)
    {
        Console.WriteLine(
            $"SMS: Transfer of {result.Amount:C} " +
            $"to {result.ToAccount} completed successfully.");
    }

    public static void SendEmail(TransferResultDto result)
    {
        Console.WriteLine(
            $"Email: Transfer from {result.FromAccount} " +
            $"to {result.ToAccount}, amount {result.Amount:C}.");
    }
}
