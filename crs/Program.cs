using DelegateFullExample.crs.DelegateExample;
using DelegateFullExample.crs.DelegateWithGenericExample;
using DelegateFullExample.crs.DelegateWithGenericExample.CurrencyRateService;
using DelegateFullExample.crs.EventExample.NotificationsServices;
using DelegateFullExample.crs.EventExample;

namespace DelegateFullExample.crs;

internal class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("---- **** Simple **** -----");
        var transferService = new TransferService();
        NotificationHandler? notification = TransferNotificationService.SendSms;
        transferService.TransferFunds(1000m, "Account1", "Account2", notification);
        Console.WriteLine("");
        notification += TransferNotificationService.SendEmail;
        transferService.TransferFunds(2000m, "Account1", "Account2", notification);
        Console.WriteLine("");
        notification -= TransferNotificationService.SendSms;
        if (notification != null)
        {
            transferService.TransferFunds(500m, "Account1", "Account2", notification);
        }
        Console.WriteLine("\n---- **** Generic **** -----");
        var currencyRateService = new CurrencyRateServiceGeneric();

        NotificationHandlerGeneric<CurrencyRateDto>? notificationCurrency = CurrencyRateChangeNotificationServiceGeneric.SendSms;
        notificationCurrency += CurrencyRateChangeNotificationServiceGeneric.SendEmail;
        currencyRateService.UpdateCurrencyRate(
            "USD",
            "EUR",
            0.85m,
            notificationCurrency);
        Console.WriteLine();

        var transferServiceGeneric = new TransferServiceGeneric();

        NotificationHandlerGeneric<TransferResultDto>? notificationTransfer = TransferNotificationServiceGeneric.SendSms;

        transferServiceGeneric.TransferFunds(
            1000m,
            "Account1",
            "Account2",
            notificationTransfer);

        Console.WriteLine();

        notificationTransfer += TransferNotificationServiceGeneric.SendEmail;

        transferServiceGeneric.TransferFunds(
            2000m,
            "Account1",
            "Account2",
            notificationTransfer);

        Console.WriteLine();

        notificationTransfer -= TransferNotificationServiceGeneric.SendSms;
        if (notificationTransfer != null)
        {
            transferServiceGeneric.TransferFunds(
                500m,
                "Account1",
                "Account2",
                notificationTransfer);
        };
        Console.WriteLine("\n--- ***** event ***** ----");

        var transferServiceEvent = new TransferServiceEvent();
        var emailTransferNotificationServiceEvent = new EmailTransferNotificationServiceEvent();
        var smsTransferNotificationServiceEvent = new SmsTransferNotificationServiceEvent();

        transferServiceEvent.TransferStatusChanged += emailTransferNotificationServiceEvent.OnTransferStatusChanged;
        transferServiceEvent.TransferStatusChanged += smsTransferNotificationServiceEvent.OnTransferStatusChanged;
        transferServiceEvent.Status = TransferStatus.Completed;

        Console.WriteLine("\nPress any key to exit...");
        Console.ReadKey();
    }
}
