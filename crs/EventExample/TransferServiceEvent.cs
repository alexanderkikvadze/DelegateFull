using DelegateFullExample.crs.DelegateWithGenericExample;

namespace DelegateFullExample.crs.EventExample;

public class TransferServiceEvent
{
    public event EventHandler<TransferStatusChangedEventArgs>? TransferStatusChanged;

    private TransferStatus _status = TransferStatus.Pending;

    public TransferStatus Status
    {
        get => _status;
        set
        {
            if (_status == value)
            {
                return;
            }
            TransferStatus oldStatus = _status;
            _status = value;
            OnTransferStatusChanged(oldStatus, _status);
        }
    }

    protected virtual void OnTransferStatusChanged(TransferStatus oldStatus, TransferStatus newStatus)
    {
        var eventArgs = new TransferStatusChangedEventArgs(oldStatus, newStatus);

        TransferStatusChanged?.Invoke(this, eventArgs);
    }

}
