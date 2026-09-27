using DelegateFullExample.crs.DelegateWithGenericExample;

namespace DelegateFullExample.crs.EventExample;

public class TransferServiceEvent(string message)
{
    public event EventHandler<TransferStatusChangedEventArgs>? TransferStatusChanged;

    private TransferStatus _status = TransferStatus.Pending;

    private string _message = message;

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
            OnTransferStatusChanged(oldStatus, _status, _message);
        }
    }

    protected virtual void OnTransferStatusChanged(TransferStatus oldStatus, TransferStatus newStatus, string message)
    {
        var eventArgs = new TransferStatusChangedEventArgs(oldStatus, newStatus, message);

        TransferStatusChanged?.Invoke(this, eventArgs);
    }

}
