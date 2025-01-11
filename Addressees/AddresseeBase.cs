using Itmo.ObjectOrientedProgramming.Lab3.Messages;
using Itmo.ObjectOrientedProgramming.Lab3.Recipients;

namespace Itmo.ObjectOrientedProgramming.Lab3.Addressees;

public abstract class AddresseeBase : IAddressee
{
    public IRecipient Recipient { get; protected set; }

    protected AddresseeBase(IRecipient recipient)
    {
        Recipient = recipient;
    }

    public virtual void SendMessage(IMessage message)
    {
        Recipient.GetMessage(message);
    }
}