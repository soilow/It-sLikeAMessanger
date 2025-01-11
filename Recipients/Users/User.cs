using Itmo.ObjectOrientedProgramming.Lab3.Messages;
using Itmo.ObjectOrientedProgramming.Lab3.Messages.Decorators;
using Itmo.ObjectOrientedProgramming.Lab3.Services.Results;
using System.Collections.ObjectModel;

namespace Itmo.ObjectOrientedProgramming.Lab3.Recipients.Users;

public class User : IUser
{
    public string Name { get; init; }

    private readonly Collection<UserMessage> _messages;

    public User(string name)
    {
        Name = name;
        _messages = new Collection<UserMessage>();
    }

    public void GetMessage(IMessage message)
    {
        var readableMessage = new UserMessage(message);

        _messages.Add(readableMessage);
    }

    public bool ReadMessage(IMessage message)
    {
        UserMessage? foundMessage = _messages.FirstOrDefault(m => m.Equals(message));

        if (foundMessage is null)
        {
            return false;
        }

        return foundMessage.MarkAsRead();
    }

    public Result IsMessageRead(IMessage message)
    {
        UserMessage? foundMessage = _messages.FirstOrDefault(m => m.Equals(message));

        if (foundMessage is null)
        {
            return new Result();
        }

        return new Result(foundMessage.IsRead);
    }
}