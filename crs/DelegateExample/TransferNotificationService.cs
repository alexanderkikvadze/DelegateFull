namespace DelegateFullExample.crs.DelegateExample;

public class TransferNotificationService
{
    public static void SendSms(string message)
    {
        Console.WriteLine($"SMS: {message}");
    }

    public static void SendEmail(string message)
    {
        Console.WriteLine($"Email: {message}");
    }
}
