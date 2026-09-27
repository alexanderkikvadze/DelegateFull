namespace DelegateFullExample.crs.EventExample;

public class TransferStatusChangedEventArgs(TransferStatus oldStatus, TransferStatus newStatus, string message) : EventArgs
{
    public TransferStatus OldStatus { get => oldStatus; }
    public TransferStatus NewStatus { get => newStatus; }
    public string Message { get => message; }
}
