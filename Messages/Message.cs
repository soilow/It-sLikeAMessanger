using Itmo.ObjectOrientedProgramming.Lab3.Services.Importances;

namespace Itmo.ObjectOrientedProgramming.Lab3.Messages;

public class Message : IMessage
{
    public string Title { get; init; }

    public string Body { get; init; }

    public Importance ImportanceLevel { get; init; }

    public Message(string title, string body, Importance importanceLevel)
    {
        Title = title;
        Body = body;
        ImportanceLevel = importanceLevel;
    }
}