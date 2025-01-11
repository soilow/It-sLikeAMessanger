namespace Itmo.ObjectOrientedProgramming.Lab3.Messages.Decorators;

public class UserMessage : MessageDecorator
{
    public bool IsRead { get; private set; } = false;

    public UserMessage(IMessage wrappee) : base(wrappee) { }

    public bool MarkAsRead()
    {
        if (IsRead)
        {
            return false;
        }

        IsRead = true;

        return true;
    }
}