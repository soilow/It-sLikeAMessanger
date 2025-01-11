using Itmo.ObjectOrientedProgramming.Lab3.Messages;
using Itmo.ObjectOrientedProgramming.Lab3.Services.Results;

namespace Itmo.ObjectOrientedProgramming.Lab3.Recipients.Users;

public interface IUser : IRecipient
{
    string Name { get; }

    bool ReadMessage(IMessage message);

    Result IsMessageRead(IMessage message);
}