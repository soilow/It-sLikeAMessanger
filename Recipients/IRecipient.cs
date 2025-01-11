using Itmo.ObjectOrientedProgramming.Lab3.Messages;

namespace Itmo.ObjectOrientedProgramming.Lab3.Recipients;

public interface IRecipient
{
    void GetMessage(IMessage message);
}