using Itmo.ObjectOrientedProgramming.Lab3.Services.Importances;

namespace Itmo.ObjectOrientedProgramming.Lab3.Messages;

public interface IMessage
{
    string Title { get; init; }

    string Body { get; init; }

    Importance ImportanceLevel { get; init; }
}