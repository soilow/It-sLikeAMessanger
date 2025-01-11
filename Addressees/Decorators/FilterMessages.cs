using Itmo.ObjectOrientedProgramming.Lab3.Messages;
using Itmo.ObjectOrientedProgramming.Lab3.Services.Importances;

namespace Itmo.ObjectOrientedProgramming.Lab3.Addressees.Decorators;

public class FilterMessages : AddresseeBase
{
    private readonly AddresseeBase _wrappee;
    private readonly Importance _messageImportanceThreshold;

    public FilterMessages(AddresseeBase wrappee, Importance importance) : base(wrappee.Recipient)
    {
        _wrappee = wrappee;
        _messageImportanceThreshold = importance;
    }

    public override void SendMessage(IMessage message)
    {
        if (message.ImportanceLevel >= _messageImportanceThreshold)
        {
            _wrappee.SendMessage(message);
        }
    }
}