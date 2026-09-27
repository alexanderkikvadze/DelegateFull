namespace DelegateFullExample.crs.EventExample.NotificationsServices;

public class EmailTransferNotificationServiceEvent
{
    public void OnTransferStatusChanged(object? sender, TransferStatusChangedEventArgs e)
    {
        Console.WriteLine($"Email notification: Transfer status changed from {e.OldStatus} to {e.NewStatus}");
    }
}
