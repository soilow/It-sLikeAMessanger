using Itmo.ObjectOrientedProgramming.Lab3.Services.Importances;

namespace Itmo.ObjectOrientedProgramming.Lab3.Messages.Decorators;

public class MessageDecorator : IMessage
{
    public string Title { get; init; }

    public string Body { get; init; }

    public Importance ImportanceLevel { get; init; }

    private readonly IMessage _wrappee;

    public MessageDecorator(IMessage wrappee)
    {
        _wrappee = wrappee;
        Title = wrappee.Title;
        Body = wrappee.Body;
        ImportanceLevel = wrappee.ImportanceLevel;
    }

    public bool Equals(IMessage other)
    {
        return _wrappee.Equals(other);
    }
}