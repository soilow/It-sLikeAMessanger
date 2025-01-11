using Itmo.ObjectOrientedProgramming.Lab3.Messages;

namespace Itmo.ObjectOrientedProgramming.Lab3.Addressees.Decorators;

public class Logger : AddresseeBase
{
    private readonly AddresseeBase _wrappee;

    public Logger(AddresseeBase wrappee) : base(wrappee.Recipient)
    {
        _wrappee = wrappee;
    }

    public override void SendMessage(IMessage message)
    {
        Console.WriteLine($"{DateTime.Now.ToString("MMM d HH:mm:ss")}: {message.Body}");
        _wrappee.SendMessage(message);
    }
}