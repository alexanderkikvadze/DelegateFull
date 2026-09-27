namespace DelegateFullExample.crs.EventExample.NotificationsServices;

internal class SmsTransferNotificationServiceEvent
{
    public void OnTransferStatusChanged(object? sender, TransferStatusChangedEventArgs e)
    {
        Console.WriteLine($"SMS notification: Transfer status changed from {e.OldStatus} to {e.NewStatus} with message: {e.Message}");
    }
}
