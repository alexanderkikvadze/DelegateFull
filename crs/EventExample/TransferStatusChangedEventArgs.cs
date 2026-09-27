namespace DelegateFullExample.crs.EventExample;

public class TransferStatusChangedEventArgs(TransferStatus oldStatus, TransferStatus newStatus) : EventArgs
{
    public TransferStatus OldStatus { get => oldStatus; }
    public TransferStatus NewStatus { get => newStatus; }
}
